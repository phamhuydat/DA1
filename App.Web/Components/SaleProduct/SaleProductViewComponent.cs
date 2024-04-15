using App.Data.Entities.Products;
using App.Data.Repositories;
using App.Web.Areas.Admin.ViewModels.Product;
using App.Web.ViewModels.Product;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Components.SaleProduct
{
	public class SaleProductViewComponent : ViewComponent
	{
		readonly GenericRepository _repo;
		public SaleProductViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var now = DateTime.Now;
			var data = await _repo
				.GetAll<AppProduct>(x => x.IsActive == true && x.DeletedDate == null
					&& (x.DiscountPrice.HasValue
					&& (x.DiscountFrom ?? DateTime.MinValue) < now
					&& (x.DiscountTo ?? DateTime.MaxValue) > now)
				)
				.OrderByDescending(x => x.DiscountPrice)
				.Take(8)
				.ProjectTo<ProductListVM>(AutoMapperProfile.ProductClientConf)
				.ToListAsync();
			return View(data);
		}
	}
}
