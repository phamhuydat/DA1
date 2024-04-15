using App.Data.Entities;
using App.Data.Repositories;
using App.Web.ViewModels.News;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Components.NewsNavBar
{
	public class NewsNavBarViewComponent : ViewComponent
	{
		readonly GenericRepository _repo;
		public NewsNavBarViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await _repo
				.GetAll<AppNews>(x => x.DeletedDate == null && x.Published == true)
				.ProjectTo<ListNewsNavBarVM>(AutoMapperProfile.NewsClientConf)
				.Take(20)
				.ToListAsync();
			return View(data);
		}
	}
}
