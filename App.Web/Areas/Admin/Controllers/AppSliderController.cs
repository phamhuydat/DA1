using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Areas.Admin.ViewModels.AppSlider;
using App.Web.Common;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Areas.Admin.Controllers
{
	public class AppSliderController : AppControllerBase
	{
		private readonly GenericRepository _repository;
		private const string MESSAGE_COMPARE_DAY = "Ngày hết hạn không thể nhỏ hơn ngày bắt đầu";

		public AppSliderController(IMapper mapper, GenericRepository repo) : base(mapper)
		{
			_repository = repo;
		}
		[AppAuthorize(AuthConst.AppSlider.VIEW_LIST)]
		public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			var data = (await _repository
				.GetAll<AppSlider>()
				.Where(x => x.DeletedDate == null)
				.ProjectTo<SliderListItemVM>(AutoMapperProfile.AppSliderConf)
				.ToPagedListAsync(page, size))
				.GenRowIndex();
			return View(data);
		}
		[AppAuthorize(AuthConst.AppSlider.CREATE)]
		public IActionResult Create() => View();
		[AppAuthorize(AuthConst.AppSlider.CREATE)]
		[HttpPost]
		public async Task<IActionResult> Create(AddOrUpdateSliderVM model)
		{
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return View(model);
			}

			if (model.ImagePath == null || model.ImagePath == "")
			{
				SetErrorMesg("Bạn chưa chọn hình!");
				return View(model);
			}

			try
			{
				model.Link = model.Link == null ? $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}" : model.Link;
				var slider = _mapper.Map<AppSlider>(model);
				slider.CreatedBy = CurrentUserId;
				await _repository.AddAsync(slider);
				SetSuccessMesg($"Thêm slider thành công");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return View(model);
			}
		}
		[AppAuthorize(AuthConst.AppSlider.UPDATE)]
		public async Task<IActionResult> Update(int id)
		{
			var slider = await _repository.FindAsync<AppSlider>(id);
			if (slider == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			var sliderVM = _mapper.Map<AddOrUpdateSliderVM>(slider);
			return View(sliderVM);
		}
		[AppAuthorize(AuthConst.AppSlider.UPDATE)]

		[HttpPost]
		public async Task<IActionResult> Update(AddOrUpdateSliderVM model)
		{
			var slider = await _repository.FindAsync<AppSlider>(model.Id);
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return View(model);
			}
			if (slider == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (model.ToDate < model.FromDate)
			{
				ModelState.AddModelError("ToDate", MESSAGE_COMPARE_DAY);
				return View(model);
			}
			try
			{
				_mapper.Map<AddOrUpdateSliderVM, AppSlider>(model, slider);
				slider.UpdatedDate = DateTime.Now;
				slider.UpdatedBy = CurrentUserId;
				await _repository.UpdateAsync(slider);
				SetSuccessMesg($"Cập nhật slider thành công");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return View(model);
			}
		}
		[AppAuthorize(AuthConst.AppSlider.DELETE)]

		public async Task<IActionResult> Delete(int id)
		{
			var slider = await _repository.FindAsync<AppSlider>(id);
			if (slider == null)
			{
				SetErrorMesg("Ảnh này không tồn tại hoặc đã được xóa trước đó");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			await _repository.DeleteAsync(slider);
			SetSuccessMesg($"Slider được xóa thành công");
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}
	}
}
