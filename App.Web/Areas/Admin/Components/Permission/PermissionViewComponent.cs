//using App.Data.Entities;
//using App.Data.Repositories;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;


//namespace App.Web.Areas.Components.Permission
//{
//	public class PermissionViewComponent : ViewComponent
//	{
//		readonly GenericRepository _repository;
//		public PermissionViewComponent(GenericRepository repository)
//		{
//			_repository = repository;
//		}

//		public async Task<IViewComponentResult> InvokeAsync()
//		{
//			var data = await _repository
//							.GetAllMst<MstPermission>()
//							.AsEnumerable()
//							.GroupBy(x => x.GroupName)
//							.ToListAsync();
//			return View(data);
//		}
//	}
//}
