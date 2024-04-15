using App.Data.Entities;
using App.Data.Entities.Products;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.ViewModels.Product;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Components.ArrivalsProduct
{
	public class ArrivalsProductViewComponent : ViewComponent
	{
		readonly GenericRepository _repo;
		public ArrivalsProductViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var cateOP = await _repo
				.GetOneAsync<AppProductCategory>(x => x.DeletedDate == null
					&& x.Name.Equals(ProductCateConst.ONE_PIECE_NAME)
					&& x.CateLevel.Equals(1));
			var data = await _repo
				.GetAll<AppProduct>(x => x.IsActive == true && x.DeletedDate == null
					&& (x.ProductCategory.Id == cateOP.Id || x.ProductCategory.ParentCateId == cateOP.Id
						|| x.ProductCategory.ParentCategory.ParentCateId == cateOP.Id)
				)
				.OrderByDescending(m => m.DisplayOrder)
				.ThenByDescending(m => m.Id)
				.Take(8)
				.ProjectTo<ProductListVM>(AutoMapperProfile.ProductClientConf)
				.ToListAsync();
			return View(data);
		}
	}
}
