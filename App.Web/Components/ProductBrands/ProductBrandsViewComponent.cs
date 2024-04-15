//using App.Data.Entities.Products;
//using App.Data.Repositories;
//using App.Web.ViewModels.ProductBrands;
//using App.Web.WebConfig;
//using AutoMapper.QueryableExtensions;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Threading.Tasks;

//namespace App.Web.Components.ProductBrands
//{
//	public class ProductBrandsViewComponent : ViewComponent
//	{
//		readonly GenericRepository _repo;
//		public ProductBrandsViewComponent(GenericRepository repo)
//		{
//			_repo = repo;
//		}
//		public async Task<IViewComponentResult> InvokeAsync()
//		{
//			var data = await _repo
//				.GetAllMst<MstProductBrand>(x => x.DeletedDate == null)
//				.ProjectTo<ListProductBrandVM>(AutoMapperProfile.MstProductBrandConf)
//				.ToListAsync();
//			return View(data);
//		}
//	}
//}
