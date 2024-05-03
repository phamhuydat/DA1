using App.Data.Entities;
using App.Data.Repositories;
using App.Web.Areas.Admin.ViewModels.ProductCategory;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace App.Web.Areas.Admin.Components.SelectListProductCategory
{
	public class SelectListProductCategoryViewComponent : ViewComponent
	{
		readonly GenericRepository repository;
		public SelectListProductCategoryViewComponent(GenericRepository _db)
		{
			repository = _db;
		}
		public async Task<IViewComponentResult> InvokeAsync(AddOrUpdateProductCategoryVM productCate)
		{
			var proCate = await repository
				.GetAll<AppProductCategory>(s => s.CateLevel.Equals(1) && s.DeletedDate == null)
				.Include(s => s.ChildCategories)
				.ThenInclude(s => s.ChildCategories)
				.ProjectTo<ListItemProductCategoryVM>(AutoMapperProfile.ProductCategoryConf)
				.ToListAsync();
			var listCategory = new SelectList(proCate, "Id", "CateLevel", -1);
			if (productCate != null)
			{
				listCategory = new SelectList(proCate, "Id", "CateLevel", productCate.ParentCateId);
			};
			ViewBag.ProductCate = listCategory;
			return View(productCate);
		}
	}
}
