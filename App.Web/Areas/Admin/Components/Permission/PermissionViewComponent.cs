using App.Data.Entities;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Areas.Components.Permission
{
    public class PermissionViewComponent : ViewComponent
    {
        readonly GenericRepository repository;
        public PermissionViewComponent(GenericRepository _repository)
        {
            repository = _repository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            int page = 1;
            int size = 25;
            var data = await repository
                            .GetAllMst<MstPermission>()
                            .AsEnumerable()
                            .GroupBy(x => x.GroupName)
                            .ToPagedListAsync(page, size);
            return View(data);
        }
    }
}
