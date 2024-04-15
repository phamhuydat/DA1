using App.Data.Entities;
using App.Data.Entities.Products;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Areas.Admin.ViewModels.Report;
using App.Web.WebConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(AuthenticationSchemes = AppConst.COOKIES_AUTH)]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		readonly GenericRepository _repository;
		public HomeController(ILogger<HomeController> logger, GenericRepository repository)
		{
			_logger = logger;
			_repository = repository;
		}

		public IActionResult Index()
		{
			var roleId = Convert.ToInt32(User.Claims.SingleOrDefault(c => c.Type.Contains(AppClaimTypes.RoleId))?.Value);
			if (roleId == AppConst.ROLE_CUSTOMER_ID)
			{
				return Redirect("/");
			}
			ViewBag.CountPendingOrder = _repository.GetAll<AppOrder>(s => s.StatusId == DB.OrderStatusId.STATUS_PENDING).Count();
			ViewBag.CountProductActive = _repository.GetAll<AppProduct>(s => s.IsActive == true).Count();
			ViewBag.CountUserUnBlock = _repository.GetAll<AppUser>(s => s.BlockedTo == null || s.BlockedTo < DateTime.Now).Count();
			ViewBag.CountNewsActive = _repository.GetAll<AppNews>(s => s.Published == true).Count();
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error(int statusCode)
		{
			return View(statusCode.ToString());
		}
		public async Task<IActionResult> Report()
		{
			var date = DateTime.Now;
			var query = await _repository.DbContext.AppOrders
				.Where(s => s.CreatedDate <= date && s.DeletedDate == null && s.StatusId == DB.OrderStatusId.STATUS_DONE)
				.OrderBy(s => s.CreatedDate.Value.Month)
				.Select(x => new
				{
					ngay = x.CreatedDate.Value.Day,
					thang = x.CreatedDate.Value.Month,
					time = x.CreatedDate.Value.TimeOfDay,
					tatol = x.Total
				}).ToListAsync();

			var result = query.GroupBy(s => s.thang)
				.Select(s => new SaleReport { Date = s.Key, TongTien = s.Sum(s => s.tatol) }).ToList();

			var firstMonth = result[0];
			var lastMonth = result[result.Count - 1];
			int count = result.Count;
			for (int i = 1; i <= 12; i++)
			{
				if (!result.Any(x => x.Date == i))
				{
					result.Add(new SaleReport { Date = i, TongTien = 0 });
				}
			}

			result.Sort(delegate (SaleReport item1, SaleReport item2)
			{
				if (item1.Date < item2.Date)
				{
					return -1;
				}
				return 1;
			});

			return Ok(result);
		}
	}
}
