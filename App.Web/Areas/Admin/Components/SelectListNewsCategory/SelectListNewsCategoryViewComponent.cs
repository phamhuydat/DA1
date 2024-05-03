using App.Data.Entities;
using App.Data.Repositories;
using App.Web.Areas.Admin.ViewModels.News;
using App.Web.Areas.Admin.ViewModels.NewsCategory;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace App.Web.Areas.Admin.Components.SelectListNewsCategory
{
	public class SelectListNewsCategoryViewComponent : ViewComponent
	{
		readonly GenericRepository repository;
		public SelectListNewsCategoryViewComponent(GenericRepository _db)
		{
			repository = _db;
		}
		public async Task<IViewComponentResult> InvokeAsync(AddOrUpdateNewsVM news)
		{
			var cate = await repository.GetAll<AppNewsCategory>()
						.ProjectTo<NewsCategoryListItemVM>(AutoMapperProfile.NewsCategoryConf)
						.ToListAsync();
			var listCategory = new SelectList(cate, "Id", "Title");
			if (news != null)
			{
				listCategory = new SelectList(cate, "Id", "Title", news.CategoryId);
			}
			ViewBag.CategoryNews = listCategory;
			return View(news);
		}
	}
}
