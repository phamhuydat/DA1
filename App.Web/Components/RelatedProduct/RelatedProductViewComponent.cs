using App.Data.Entities;
using App.Data.Entities.Products;
using App.Data.Repositories;
using App.Web.ViewModels.Product;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Components.RelatedProduct
{
	public class RelatedProductViewComponent : ViewComponent
	{
		readonly GenericRepository _repo;
		public RelatedProductViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await _repo
				.GetAll<AppProduct>(x => x.IsActive == true && x.DeletedDate == null)
				.OrderByDescending(m => m.DisplayOrder)
				.ThenByDescending(m => m.Id)
				.Take(8)
				.ProjectTo<ProductListVM>(AutoMapperProfile.ProductClientConf)
				.ToListAsync();
			return View(data);
		}
	}
}
