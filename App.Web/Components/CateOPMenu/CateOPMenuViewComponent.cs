using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.ViewModels.ProductCategory;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Components.CateOPMenu
{
	public class CateOPMenuViewComponent : ViewComponent
	{
		readonly GenericRepository _repo;
		public CateOPMenuViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await _repo
				.GetAll<AppProductCategory>(x => x.DeletedDate == null && x.ParentCategory.Name.Equals(ProductCateConst.ONE_PIECE_NAME) && x.CateLevel.Equals(2))
				.OrderBy(x => x.Id)
				.ProjectTo<CateMenuVM>(AutoMapperProfile.ProductCategoryClientConf)
				.ToListAsync();
			return View(data);
		}
	}
}
