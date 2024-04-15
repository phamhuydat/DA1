using App.Data.Entities;
using App.Data.Repositories;
using App.Web.Areas.Admin.ViewModels.AppDiscountCode;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Areas.Admin.Components.SelectListCategoryDCode
{
	public class SelectListCategoryDCodeViewComponent : ViewComponent
	{
		private readonly GenericRepository _repo;

		public SelectListCategoryDCodeViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}
		public async Task<IViewComponentResult> InvokeAsync(AddOrUpdateDiscountCodeVM discountCode)
		{
			var cateLv1 = await _repo
				.GetAll<AppProductCategory>(x => x.CateLevel.Equals(1) && x.DeletedDate == null)
				.ToListAsync();
			var selectList = new SelectList(cateLv1, "Id", "Name");
			if(discountCode != null)
			{
				selectList = new SelectList(cateLv1, "Id", "Name", discountCode.UnApplyCategoryId);
			}
			ViewBag.ListCate = selectList;
			return View(discountCode);
		}
	}
}
