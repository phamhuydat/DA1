using App.Data.Repositories;
using App.Share.Extensions;
using App.Web.Areas.Admin.ViewModels.Product;
using App.Web.ViewModels.Product;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Components.RecentProduct
{
	public class RecentProductViewComponent : ViewComponent
	{
		readonly GenericRepository _repo;
		public RecentProductViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var prodId = GetRecentProductId();
			var data = await _repo.DbContext.AppProducts
						.Where(x => prodId.Contains(x.Id) && x.DeletedDate == null && x.IsActive)
						.ProjectTo<ProductListVM>(AutoMapperProfile.ProductClientConf)
						.ToListAsync();
			return View(data);
		}

		private List<int> GetRecentProductId()
		{
			var key = "RecentProduct";
			var sesVal = HttpContext.Session.GetString(key);
			if (sesVal.IsNullOrEmpty())
			{
				return new List<int>();
			}
			var productId = JsonConvert.DeserializeObject<List<int>>(sesVal);
			return productId;
		}
	}
}
