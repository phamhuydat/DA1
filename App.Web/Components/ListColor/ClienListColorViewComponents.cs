using App.Data.Entities.Products;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Components.ListColor
{
    public class ClienListColorViewComponents : ViewComponent
    {
        private readonly GenericRepository _repo;

        public ClienListColorViewComponents(GenericRepository repo)
        {
            _repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var data = _repo.GetAll<AppProductDetail>()
                .Where(x => x.ProductId == id)
                .Select(x => x.ColorId)
                .ToListAsync();
            return View(data);
        }
    }
}
