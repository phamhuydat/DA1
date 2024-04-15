using App.Data.Entities;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace App.Web.Areas.Admin.Components.ListMstOrderStatus
{
    public class SelectListMstOrderStatusViewComponent : ViewComponent
    {
        readonly GenericRepository _repo;
        public SelectListMstOrderStatusViewComponent(GenericRepository repo)
        {
            _repo = repo;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listOrderStatus = await _repo
                .GetAllMst<MstOrderStatus>()
                .ToListAsync();
            var selectListOrderStatus = new SelectList(listOrderStatus, "Id", "Name");
            ViewBag.SelectListStatus = selectListOrderStatus;
            return View();
        }
    }
}
