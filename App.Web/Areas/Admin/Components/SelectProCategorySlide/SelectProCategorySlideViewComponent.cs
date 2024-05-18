using App.Data.Entities;
using App.Data.Repositories;
using App.Web.Areas.Admin.ViewModels.AppSlider;
using App.Web.Areas.Admin.ViewModels.ProductCategory;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace App.Web.Areas.Admin.Components.SelectProCategorySlide
{
	public class SelectProCategorySlideViewComponent : ViewComponent
	{
		readonly GenericRepository _repo;
		public SelectProCategorySlideViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}

		public async Task<IViewComponentResult> InvokeAsync(AddOrUpdateSliderVM slide)
		{
			var proCate = await _repo
				.GetAll<AppProductCategory>(s => s.DeletedDate == null && s.CateLevel == 1)
				.ProjectTo<ListProductCateSelectVM>(AutoMapperProfile.ProductCategorySelectConf).ToListAsync();

			var listCategory = new SelectList(proCate, "Id", "Name", -1, "CateLevel");
			if (slide != null)
			{
				listCategory = new SelectList(proCate, "Id", "Name", slide.CategoryId, "CateLevel");
			};
			ViewBag.ProductCateSlide = listCategory;
			return View(slide);
		}
	}
}
