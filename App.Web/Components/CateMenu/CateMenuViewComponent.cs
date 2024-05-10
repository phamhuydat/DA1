using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Components.CateMenu;
using App.Web.ViewModels.ProductCategory;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Components.CateOPMenu
{
    public class CateMenuViewComponent : ViewComponent
    {
        readonly GenericRepository _repo;
        public CateMenuViewComponent(GenericRepository repo)
        {
            _repo = repo;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var data = await _repo.DbContext
                .AppProductCategories
                .Where(x => x.DeletedDate == null && x.ParentCateId == id)
                .OrderBy(x => x.DisplayOrder)
                .Select(x => new CateMenuViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Slug = x.Slug,
                })
                .ToListAsync();
            return View(data);
        }
    }
}
