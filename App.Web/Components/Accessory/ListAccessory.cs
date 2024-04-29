using App.Data.Entities.Products;
using App.Data.Repositories;
using AspNetCore;
using Microsoft.AspNetCore.Mvc;

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
            var data = _repo.GetAll<AppProduct>()
                .Where(u => u.CategoryId == cate)
                .Where(u => u.Id == pro)
                .Take(4)
                .ToList();
            return View(data);
        }
    }
}
