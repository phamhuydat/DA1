using App.Data.Entities;
using App.Data.Repositories;
using App.Web.Areas.Admin.ViewModels.ProductCategory;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Areas.Admin.Components.ListProductCategory
{
    public class ListProductCategoryViewComponent : ViewComponent
    {
        readonly GenericRepository _repository;
        public ListProductCategoryViewComponent(GenericRepository repository)
        {
            _repository = repository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await _repository
                .GetAll<AppProductCategory>(x => /*x.CateLevel.Equals(1) &&*/ x.DeletedDate == null)
                .Include(x => x.AppProducts)
                //.Include(x => x.ChildCategories)
                //.ThenInclude(x => x.ChildCategories)
                //.ThenInclude(x => x.a)
                .ProjectTo<ListItemProductCategoryVM>(AutoMapperProfile.ProductCategoryConf)
                .OrderBy(x => x.DisplayOrder)
                .ToListAsync();
            return View(data);
        }
    }
}
