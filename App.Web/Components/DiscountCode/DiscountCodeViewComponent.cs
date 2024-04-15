using App.Data.Entities;
using App.Data.Repositories;
using App.Web.ViewModels.AppDiscountCode;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Web.Components.DiscountCode
{
	public class DiscountCodeViewComponent : ViewComponent
	{
		readonly GenericRepository _repo;
		public DiscountCodeViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await _repo
				.GetAll<AppDiscountCode>(x => x.DeletedDate == null)
				.ProjectTo<AppDiscountCodeListItemVM>(AutoMapperProfile.AppDiscountCodeConf)
				.ToListAsync();
			foreach (var item in data)
			{
				var groupName = await _repo.FindAsync<AppProductCategory>(item.UnApplyCategoryId ?? 0);
				if (groupName != null)
				{
					item.GroupNameCategory = groupName.GroupName;
				}
			}
			return View(data);
		}
	}
}
