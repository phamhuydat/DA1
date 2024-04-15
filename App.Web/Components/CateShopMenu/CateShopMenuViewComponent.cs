﻿using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.ViewModels.ProductCategory;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace App.Web.Components.CateShopMenu
{
	public class CateShopMenuViewComponent : ViewComponent
	{
		readonly GenericRepository _repo;
		public CateShopMenuViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await _repo
				.GetAll<AppProductCategory>(x => x.DeletedDate == null && x.GroupName.Equals(ProductCateConst.SHOP_GROUPNAME) && x.CateLevel.Equals(1))
				.OrderBy(x => x.Id)
				.ProjectTo<CateMenuVM>(AutoMapperProfile.ProductCategoryClientConf)
				.ToListAsync();
			return View(data);
		}
	}
}
