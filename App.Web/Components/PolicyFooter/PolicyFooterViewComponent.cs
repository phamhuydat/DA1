using App.Data.Entities;
using App.Data.Repositories;
using App.Web.ViewModels.Policy;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace App.Web.Components.PolicyFooter
{
	public class PolicyFooterViewComponent : ViewComponent
	{
		readonly GenericRepository _repo;
		public PolicyFooterViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await _repo
				.GetAll<AppPolicy>(x => x.DeletedDate == null)
				.ProjectTo<ListPolicyFooterVM>(AutoMapperProfile.AppPolicyConf)
				.ToListAsync();
			return View(data);
		}
	}
}
