//using App.Data.Entities;
//using App.Data.Repositories;
//using App.Web.ViewModels.AppBranch;
//using App.Web.WebConfig;
//using AutoMapper.QueryableExtensions;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Linq;
//using System.Threading.Tasks;
//using X.PagedList;

//namespace App.Web.Components.BranchFooter
//{
//	public class BranchFooterViewComponent : ViewComponent
//	{
//		readonly GenericRepository _repo;
//		public BranchFooterViewComponent(GenericRepository repo)
//		{
//			_repo = repo;
//		}
//		public async Task<IViewComponentResult> InvokeAsync()
//		{
//			var data = await _repo
//				.GetAll<AppBranch>(x => x.DeletedDate == null)
//				.OrderBy(x => x.Id)
//				.ProjectTo<ListBranchVM>(AutoMapperProfile.AppBranchConf)
//				.AsEnumerable()
//				.GroupBy(x => x.GroupName)
//				.ToListAsync();
//			return View(data);
//		}
//	}
//}
