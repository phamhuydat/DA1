using App.Data.Entities.Products;
using App.Data.Repositories;
using App.Web.ViewModels.Product;
using App.Web.WebConfig;
using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Components.Accessory
{
    public class ListAccessory : ViewComponent
    {
        GenericRepository _repo;
        public ListAccessory(GenericRepository repo)
        {
            _repo = repo;
        }
        public async Task<IViewComponentResult> InvokeAsync(int cate, int pro)
        {
            var data = await _repo.GetAll<AppProduct, ProductListVM>
                (AutoMapperProfile.ProductClientConf)
                .Where(u => u.CategoryId == cate)
                .Where(u => u.Id == pro)
                .Take(4)
                .ToListAsync();
            return View(data);
        }
    }
}
