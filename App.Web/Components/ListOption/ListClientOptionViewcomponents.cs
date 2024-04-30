using App.Data.Entities.Products;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Components.ListOption
{
    public class ListClientOptionViewcomponents : ViewComponent
    {
        private readonly GenericRepository _repo;

        public ListClientOptionViewcomponents(GenericRepository _repo)
        {
            _repo = _repo;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var ram = _repo.GetAll<AppProductDetail>()
                .Where(p => p.Id == id)
                .Select(x => x.Ram)
                .ToListAsync();

            var rom = _repo.GetAll<AppProductDetail>()
                .Where(p => p.Id == id)
                .Select(x => x.Rom)
                .ToListAsync();

            return View(rom);
        }
    }
}
