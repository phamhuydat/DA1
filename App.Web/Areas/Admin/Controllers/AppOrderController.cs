using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Extensions;
using App.Web.Areas.Admin.ViewModels.Order;
using App.Web.Common;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Areas.Admin.Controllers
{
	public class AppOrderController : AppControllerBase
	{
		private readonly GenericRepository _repo;
		public AppOrderController(IMapper mapper, GenericRepository repo) : base(mapper)
		{
			_repo = repo;
		}
		[AppAuthorize(AuthConst.AppOrder.VIEW_LIST)]
		public async Task<IActionResult> Index(SearchOrderVM search, int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			var data = (await _repo
				.GetAll<AppOrder>()
				.Where(x => !search.Name.IsNullOrEmpty() ? x.CusName.Contains(search.Name) : true)
				.Where(x => !search.Phone.IsNullOrEmpty() ? x.CusPhone.Contains(search.Phone) : true)
				.Where(x => search.OrderStatusId != null ? x.StatusId == search.OrderStatusId : true)
				.ProjectTo<ListItemOrderVM>(AutoMapperProfile.OrderConf)
				.ToPagedListAsync(page, size))
				.GenRowIndex();

			var listOrderStatus = await _repo
				.GetAllMst<MstOrderStatus>()
				.ToListAsync();

			ViewBag.OrdersStatus = new SelectList(listOrderStatus, "Id", "Name", search.OrderStatusId);
			ViewBag.Name = search.Name;
			ViewBag.Phone = search.Phone;
			ViewBag.OrderStatusId = search.OrderStatusId;
			return View(data);
		}
		[AppAuthorize(AuthConst.AppOrder.DETAILS)]
		public async Task<IActionResult> OrderDetail(int id)
		{
			var order = await _repo
				.GetAll<AppOrder>()
				.ProjectTo<ListItemOrderVM>(AutoMapperProfile.OrderConf)
				.SingleOrDefaultAsync(x => x.Id == id);
			return View(order);
		}
		[AppAuthorize(AuthConst.AppOrder.UPDATE)]
		[HttpPost]
		public async Task<IActionResult> UpdateOrderStatus(int id = 0, int statusId = 0)
		{
			var statusResult = false;
			if (id == 0 || statusId == 0)
			{
				return Ok(Result(statusResult, ""));
			}
			var order = await _repo.FindAsync<AppOrder>(id);
			if (order == null)
			{
				return Ok(Result(statusResult, ""));
			}

			order.StatusId = statusId;
			order.UpdatedDate = DateTime.Now;
			await _repo.UpdateAsync(order);

			statusResult = true;
			var status = await _repo
				.GetAllMst<MstOrderStatus>()
				.SingleOrDefaultAsync(x => x.Id == statusId);
			return Ok(Result(statusResult, status.Name));
		}
		[AppAuthorize(AuthConst.AppOrder.DELETE)]
		public async Task<IActionResult> Delete(int id)
		{
			var order = await _repo
				.GetAll<AppOrder>()
				.Include(x => x.AppOrderDetails)
				.SingleOrDefaultAsync(x => x.Id == id);
			if (order == null)
			{
				SetErrorMesg("Đơn hàng không tồn tại hoặc đã được xóa trước đó!");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (order.AppOrderDetails.Count > 0)
			{
				foreach (var item in order.AppOrderDetails)
				{
					await _repo.DeleteAsync(item);
				}
			}
			await _repo.DeleteAsync(order);
			SetSuccessMesg("Đơn hàng đã được xóa thành công!");
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}

		[AppAuthorize(AuthConst.AppOrder.DELETE)]
		public async Task<IActionResult> BulkDelete(List<int> ids)
		{
			await _repo.DeleteAsync<AppOrder>(ids);
			SetSuccessMesg($"Đã xóa {ids.Count} đơn hàng!");
			if (String.IsNullOrEmpty(Referer))
			{
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			return Redirect(Referer);
		}

		private object Result(bool statusResult, string orderStatusName)
		{
			return new
			{
				StatusResult = statusResult,
				OrderStatusName = orderStatusName
			};
		}
	}
}
