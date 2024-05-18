using App.Data.Entities;
using App.Data.Repositories;
using App.Web.Areas.Admin.ViewModels.Product;
using App.Web.Areas.Admin.ViewModels.ProductCategory;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace App.Web.Areas.Admin.Components.Product
{
	public class SelectProductCategoryViewComponent : ViewComponent
	{
		readonly GenericRepository repository;
		public SelectProductCategoryViewComponent(GenericRepository _db)
		{
			repository = _db;
		}
		public async Task<IViewComponentResult> InvokeAsync(AddOrUpdateProductVM product)
		{
			var proCate = await repository
				.GetAll<AppProductCategory>(s => /*(s.CateLevel.Equals(2) || s.CateLevel.Equals(3)) &&*/ s.DeletedDate == null)
				.ProjectTo<ListProductCateSelectVM>(AutoMapperProfile.ProductCategorySelectConf)
				.ToListAsync();

			var listCategory = new SelectList(proCate, "Id", "Name", -1, "CateLevel");
			if (product != null)
			{
				listCategory = new SelectList(proCate, "Id", "Name", product.CategoryId, "CateLevel");
			};
			ViewBag.ProductCate = listCategory;
			return View(product);
		}
	}
}
