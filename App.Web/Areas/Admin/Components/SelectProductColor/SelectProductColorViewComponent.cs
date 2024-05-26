using App.Data.Entities.Products;
using App.Data.Repositories;
using App.Web.Areas.Admin.ViewModels.Product;
using App.Web.Areas.Admin.ViewModels.ProductCategory;
using App.Web.WebConfig;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Areas.Admin.Components.SelectProductColor
{
    public class SelectProductColorViewComponent : ViewComponent
    {
        readonly GenericRepository repository;
        public SelectProductColorViewComponent(GenericRepository _db)
        {
            repository = _db;
        }
        public async Task<IViewComponentResult> InvokeAsync(AddOrUpProOptionVM product)
        {
            var proColor = await repository
                .GetAllMst<MstProductColor>()
                .Where(x => x.DeletedDate == null)
                .OrderByDescending(s => s.CreatedDate)
                .ToListAsync();
            var listColor = new SelectList(proColor, "Id", "ColorName", -1);
            if (product != null)
            {
                listColor = new SelectList(proColor, "Id", "ColorName", product.ColorId);
            }
            ViewBag.ProductColor = listColor;
            return View(product);


        }
    }
}
