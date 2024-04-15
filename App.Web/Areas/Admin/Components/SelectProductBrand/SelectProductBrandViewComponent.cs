//using App.Data.Repositories;
//using App.Web.Areas.Admin.ViewModels.Product;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.AspNetCore.Mvc;
//using System.Threading.Tasks;
//using App.Data.Entities.Products;
//using System.Linq;
//using Microsoft.EntityFrameworkCore;

//namespace App.Web.Areas.Admin.Components.Product
//{
//	public class SelectProductBrandViewComponent : ViewComponent
//	{
//		readonly GenericRepository repository;
//		public SelectProductBrandViewComponent(GenericRepository _db)
//		{
//			repository = _db;
//		}
//		public async Task<IViewComponentResult> InvokeAsync(AddOrUpdateProductVM product)
//		{
//			var proBrand = await repository
//				.GetAllMst<MstProductBrand>()
//				.Where(x => x.DeletedDate == null)
//				.OrderByDescending(s => s.CreatedDate)
//				.ToListAsync();

//			var listBrand = new SelectList(proBrand, "Id", "Name", -1);
//			if (product != null)
//			{
//				listBrand = new SelectList(proBrand, "Id", "Name", product.BrandId);
//			};
//			ViewBag.ProductBrand = listBrand;
//			return View(product);
//		}
//	}
//}
