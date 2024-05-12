using App.Data.Entities;
using App.Data.Entities.Products;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Common;
using App.Web.Common.Mailer;
using App.Web.ViewModels.Cart;
using App.Web.WebConfig;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Humanizer.Localisation.DateToOrdinalWords;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TextTemplating;
using System.Drawing;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using RazorEngine;
using RazorEngine.Templating;

namespace App.Web.Controllers
{
	public class CartController : BaseController
	{
		private readonly INotyfService _notyf;
		private readonly IHostingEnvironment _env;
		private readonly AppMailConfiguration _mailConfig;
		private readonly IHttpContextAccessor _contextAccessor;


		public CartController(IMapper mapper, GenericRepository repo, INotyfService notyf, AppMailConfiguration mailConfig, IHostingEnvironment env,
			IHttpContextAccessor contextAccessor) : base(mapper, repo)
		{
			_notyf = notyf;
			_mailConfig = mailConfig;
			_env = env;
			_contextAccessor = contextAccessor;
		}
		[Route("/gio-hang")]
		public async Task<IActionResult> Index()
		{
			var data = await GetCartFromCustomer();

			// Tạo thông tin đặt hàng nếu đã đăng nhập
			if (User.Identity.IsAuthenticated)
			{
				var userId = CurrentUserId;
				var cusData = await _repository.GetOneAsync<AppUser>(x => x.Id == userId);

				var orderData = new OrderDataVM
				{
					CusEmail = cusData.Email,
					CusName = cusData.FullName,
					DeliveryAddress = cusData.Address,
					CusPhone = cusData.PhoneNumber,
				};
				ViewBag.CusData = orderData;
			}
			return View(data);
		}

		[HttpPost]
		[AppAuthorize]
		public async Task<IActionResult> Order(OrderDataVM model)
		{
			if (!ModelState.IsValid)
			{
				_notyf.Error("Dữ liệu không hợp lệ, vui lòng kiểm tra lại", 10);
				return RedirectToAction(nameof(Index));
			}
			if (model != null)
			{
				var orderDetail = await GetCartFromCustomer();
				foreach (var detail in orderDetail)
				{
					//var currentID = Convert.ToInt32(detail.Key.Replace("products_", ""));
					var product = await _repository.FindAsync<AppProductDetail>(detail.Id);
					if (product.InStock < detail.Quantity)
					{
						_notyf.Error($"Số lượng sản phầm [{detail.ProductName}] trong kho không đủ [{product.InStock}]", 10);
						return RedirectToAction("Index", "Cart");
					}
				}

				await AddDataToOrder(model);

				RemoveAllCartData();
				_notyf.Success("Đơn đặt hàng đã được gửi thành công!", 10);
				return RedirectToAction("Index", "Home");
			}
			return Ok();
		}

		private async Task AddDataToOrder(OrderDataVM model)
		{
			model.StatusId = DB.OrderStatusId.STATUS_PENDING;
			var order = new AppOrder();
			var qualityPro = 0;

			_mapper.Map(model, order);


			var orderDetail = await GetCartFromCustomer();
			foreach (var detail in orderDetail)
			{
				//var currentID = Convert.ToInt32(detail.Key.Replace("products_", ""));
				var product = await _repository.FindAsync<AppProductDetail>(detail.Id);

				product.InStock -= detail.Quantity;
				product.Sold += detail.Quantity;

				var tmp = new AppOrderDetail
				{
					ProductId = detail.Id,
					ProductName = detail.ProductName,
					ProductPrice = detail.FinalPrice,
					Price = detail.FinalPrice * detail.Quantity,
					Quantity = detail.Quantity,
					CreatedBy = CurrentUserId,
					CreatedDate = DateTime.Now,
					UpdatedBy = CurrentUserId,
					UpdatedDate = DateTime.Now,
					ImagePath = detail.ImagePath
				};
				order.AppOrderDetails.Add(tmp);
				await _repository.UpdateAsync(product);
			}
			var count = orderDetail.Select(s => s.Quantity).Sum();

			SendEmailSuccessOrder(model.CusName,
				model.CusEmail, model.CusPhone, model.DeliveryAddress, order.Total, orderDetail.Select(s => s.Quantity).Sum());
			await _repository.AddAsync(order);
		}

		private async Task<List<CartItemVM>> GetCartFromCustomer()
		{
			//Lấy cookie
			String[] cookie = Request.Cookies.Keys.Where(c => c.IndexOf("prodcutcart_") == 0).ToArray();
			List<CartItemVM> cartItems = new List<CartItemVM>();
			foreach (var item in cookie)
			{
				cartItems.Add(new CartItemVM
				{
					Id = Convert.ToInt32(item.Split('_')[2]),
					ProductId = Convert.ToInt32(item.Split('_')[1]),
					Quantity = Convert.ToInt32(Request.Cookies[item])
				});
			}

			// Get dữ liệu sản phẩm dựa vào cookie giỏ hàng
			//var productIds = cartItems.Select(x => x.Id).ToList();          
			var productIds = cartItems.Select(x => x.Id).ToList();
			var data = await _repository.GetAll<AppProductDetail, CartItemVM>(
							AutoMapperProfile.CartConf,
							false,
							where: x => productIds.Contains(x.Id))
						.ToListAsync();


			for (int i = 0; i < data.Count; i++)
			{
				var tmp = cartItems.SingleOrDefault(x => x.Id == data[i].Id);
				if (tmp != null)
				{
					data[i].Quantity = tmp.Quantity;
				}
			}

			// Xóa sản phẩm không khả dụng (bị xóa hoặc có IsActive == false) đã được thêm vào giỏ hàng trước đó
			//var invalidIds = productIds.Where(x => !data.Select(x => x.Id).ToList().Contains(x)).ToList();
			//foreach (var x in invalidIds)
			//{
			//    Response.Cookies.Delete("prodcutcart_" + x);
			//}

			return data ?? new List<CartItemVM>();
		}

		private void RemoveAllCartData()
		{
			String[] cookie = Request.Cookies.Keys.Where(c => c.IndexOf("prodcutcart_") == 0).ToArray();
			foreach (var item in cookie)
			{
				Response.Cookies.Delete(item);
			}
		}
		public async Task<IActionResult> AddVoucher(string voucher)
		{
			var data = await _repository.GetOneAsync<AppVoucher>(x => x.Code == voucher);
			if (data != null)
			{
				return Ok(data);
			}
			else
			{
				return Ok(false);
			}
		}
		private void SendEmailSuccessOrder([FromServices] string cusName, string email, string phone, string address, decimal TotalPrice, int qualityPro)
		{
			var pathToFile = $"{_env.WebRootPath}" +
					$"{Path.DirectorySeparatorChar}" +
					$"emailTemplate{Path.DirectorySeparatorChar}emailSuccessOrder.html";

			var appMailSender = new AppMailSender()
			{
				Name = "Admin",
				Subject = $"Thông tin đến khách hàng về đơn hàng!"
			};

			using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile))
			{
				appMailSender.Content = SourceReader.ReadToEnd();
			};

			var appMailReciver = new AppMailReciver()
			{
				Email = email,
				Name = cusName
			};

			var listMailReciver = new List<AppMailReciver>();
			listMailReciver.Add(appMailReciver);


			var contentMessage = RazorEngine.Engine.Razor
				.RunCompile(appMailSender.Content, "@",
				null,
				new
				{
					Name = appMailReciver.Name,
					TotalPrice = TotalPrice.ToString("#,0 VNĐ"),
					Phone = phone,
					Email = email,
					Address = address,
					QualityPro = qualityPro,
					Signature = _mailConfig.Signature,
					Year = DateTime.Now.Year,
					CompanyName = appMailSender.Name,
					LogoCompany = ""
				});

			appMailSender.Content = contentMessage;
			AppMailer.SendToList(appMailSender, listMailReciver.AsEnumerable(), _mailConfig);
		}
		public IActionResult Completed([FromServices] CartItemVM model)
		{


			return View();
		}
	}
}
