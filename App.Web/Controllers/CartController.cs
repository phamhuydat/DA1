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
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Controllers
{
    public class CartController : BaseController
    {
        private readonly INotyfService _notyf;

        public CartController(IMapper mapper, GenericRepository repo, INotyfService notyf) : base(mapper, repo)
        {
            _notyf = notyf;
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
                    CusNote = ""
                };
                ViewBag.CusData = orderData;
            }
            return View(data);
        }

        private async Task<List<CartItemVM>> GetCartFromCustomer()
        {
            //Lấy cookie
            String[] cookie = Request.Cookies.Keys.Where(c => c.IndexOf("sp_") == 0).ToArray();
            List<CartItemVM> cartItems = new List<CartItemVM>();
            foreach (var item in cookie)
            {
                var listId = item.Split('_');
                cartItems.Add(new CartItemVM
                {
                    Id = Convert.ToInt32(item.Split('_')[1]),
                    Quantity = Convert.ToInt32(Request.Cookies[item])
                });
            }

            // Get dữ liệu sản phẩm dựa vào cookie giỏ hàng
            var productTempIds = cartItems.Select(x => x.Id).ToList();

            var data = await _repository.GetAll<AppProduct, CartItemVM>(
                             AutoMapperProfile.CartConf,
                             false,
                             where: x => productTempIds.Contains(x.Id) && x.IsActive)
                            .ToListAsync();

            var productIds = cartItems.Select(x => x.Id).ToList();
            for (int i = 0; i < data.Count; i++)
            {
                var tmp = cartItems.SingleOrDefault(x => x.Id == data[i].Id);
                if (tmp != null)
                {
                    data[i].Quantity = tmp.Quantity;
                }
            }

            // Xóa sản phẩm không khả dụng (bị xóa hoặc có IsActive == false) đã được thêm vào giỏ hàng trước đó

            var invalidIds = productTempIds.Where(x => !data.Select(x => x.Id).ToList().Contains(x)).ToList();
            foreach (var x in invalidIds)
            {
                String[] cookies = Request.Cookies.Keys.Where(c => c.IndexOf("sp_" + x) == 0).ToArray();
                foreach (var item in cookies)
                {
                    Response.Cookies.Delete(item);
                }
            }
            return data ?? new List<CartItemVM>();
        }

        private void RemoveAllCartData()
        {
            String[] cookie = Request.Cookies.Keys.Where(c => c.IndexOf("sp_") == 0).ToArray();
            foreach (var item in cookie)
            {
                Response.Cookies.Delete(item);
            }
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
            await AddDataToOrder(model);
            RemoveAllCartData();
            _notyf.Success("Đơn đặt hàng đã được gửi thành công!", 10);
            return RedirectToAction("Index", "Home");
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
                order.Total += tmp.Price;
                order.AppOrderDetails.Add(tmp);
            }
            var count = orderDetail.Select(s => s.Quantity).Sum();
            //SendEmailSuccessOrder(model.CusName,
            //    model.CusEmail, model.CusPhone, model.DeliveryAddress, order.Total, orderDetail.Select(s => s.Quantity).Sum());
            await _repository.AddAsync(order);
        }

        public async Task<IActionResult> AddVoucher(string voucher)
        {
            var data = await _repository.GetOneAsync<AppDiscountCode>(x => x.Code == voucher);
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return Ok(false);
            }
        }
        public IActionResult Completed()
        {
            return View();
        }
    }
}
