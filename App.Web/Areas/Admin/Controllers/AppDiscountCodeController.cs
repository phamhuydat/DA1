using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Areas.Admin.ViewModels.AppDiscountCode;
using App.Web.Common;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Areas.Admin.Controllers
{
	public class AppDiscountCodeController : AppControllerBase
	{
		private readonly GenericRepository _repo;

		public AppDiscountCodeController(IMapper mapper, GenericRepository repo) : base(mapper)
		{
			_repo = repo;
		}
		[AppAuthorize(AuthConst.AppDiscountCode.VIEW_LIST)]
		public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			var listDC = await _repo
				.GetAll<AppVoucher>(x => x.DeletedDate == null)
				.ProjectTo<DiscountCodeListItemVM>(AutoMapperProfile.AppDiscountCodeConf)
				.ToListAsync();
			foreach (var item in listDC)
			{
				var groupName = await _repo.FindAsync<AppProductCategory>(item.UnApplyCategoryId ?? 0);
				if (groupName != null)
				{
					item.GroupNameCategory = groupName.Name;
				}
			}
			var data = (await listDC
				.ToPagedListAsync(page, size));
			return View(data);
		}
		[AppAuthorize(AuthConst.AppDiscountCode.CREATE)]
		public IActionResult Create() => View();
		[HttpPost]
		[AppAuthorize(AuthConst.AppDiscountCode.CREATE)]
		public async Task<IActionResult> Create(AddOrUpdateDiscountCodeVM model)
		{
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return View(model);
			}
			if (await _repo.AnyAsync<AppVoucher>(x => x.Code.ToLower().Equals(model.Code.ToLower()) && x.DeletedDate == null))
			{
				SetErrorMesg("Mã khuyến mãi này đã tồn tại!");
				return View(model);
			}
			try
			{
				var discountCode = _mapper.Map<AppVoucher>(model);
				await _repo.AddAsync(discountCode);
				SetSuccessMesg($"Thêm mã khuyến mãi [{discountCode.Code}] thành công!");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return View(model);
			}
		}
		[AppAuthorize(AuthConst.AppDiscountCode.UPDATE)]
		public async Task<IActionResult> Update(int id)
		{
			var discountCode = await _repo.FindAsync<AppVoucher>(id);
			if (discountCode == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			var dCodeVM = _mapper.Map<AddOrUpdateDiscountCodeVM>(discountCode);
			return View(dCodeVM);
		}
		[AppAuthorize(AuthConst.AppDiscountCode.UPDATE)]
		[HttpPost]
		public async Task<IActionResult> Update(AddOrUpdateDiscountCodeVM model)
		{
			var discountCode = await _repo.FindAsync<AppVoucher>(model.Id);
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return View(model);
			}
			if (discountCode == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (await _repo.AnyAsync<AppVoucher>(u => u.Code.ToLower().Equals(model.Code.ToLower()) && u.Code.ToLower() != discountCode.Code.ToLower() && u.DeletedDate == null))
			{
				SetErrorMesg("Thương hiệu này đã tồn tại!");
				return View(model);
			}
			try
			{
				_mapper.Map<AddOrUpdateDiscountCodeVM, AppVoucher>(model, discountCode);
				await _repo.UpdateAsync(discountCode);
				SetSuccessMesg($"Cập nhật thương hiệu [{discountCode.Code}] thành công!");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return View(model);
			}
		}
		[AppAuthorize(AuthConst.AppDiscountCode.DELETE)]
		public async Task<IActionResult> Delete(int id)
		{
			var discountCode = await _repo.FindAsync<AppVoucher>(id);
			if (discountCode == null)
			{
				SetErrorMesg("Mã khuyến mãi không tồn tại hoặc đã được xóa trước đó!");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (await _repo.AnyAsync<AppOrder>(x => x.DiscountCodeId.Equals(discountCode.Id)))
			{
				SetErrorMesg("Mã khuyến mãi có tồn tại đơn hàng, không thể xóa!");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			await _repo.DeleteAsync(discountCode);
			SetSuccessMesg($"Mã khuyến mãi [{discountCode.Code}] được xóa thành công!");
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}
	}
}
