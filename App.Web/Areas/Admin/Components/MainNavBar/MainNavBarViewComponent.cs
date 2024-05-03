using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Areas.Admin.Components.MainNavBar
{
	public class MainNavBarViewComponent : ViewComponent
	{
		readonly GenericRepository repository;
		public MainNavBarViewComponent(GenericRepository _repository)
		{
			repository = _repository;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var navBar = new NavBarViewModel();
			navBar.Items.AddRange(new MenuItem[]
			{
				new MenuItem
				{
					Area = "Admin",
					Action = "Index",
					Controller = "Home",
					DisplayText = "Dashboard",
					Icon = "fa-chart-line"
				},
				new MenuItem
				{
					Area = "Admin",
					Action = "Index",
					Controller = "AppOrder",
					DisplayText = "Quản lý đơn hàng",
					Icon = "fa-layer-group",
					Permission = AuthConst.AppOrder.VIEW_LIST
				},
				new MenuItem
				{
					DisplayText = "Tài khoản",
					Icon = "fa-users",
					ChildrenItems = new MenuItem[]
					{
						new MenuItem
						{
							Area = "Admin",
							Action = "Index",
							Controller = "Role",
							DisplayText = "Quản lý phân quyền",
							Icon = "fa-user-shield",
							Permission = AuthConst.AppRole.VIEW_LIST,
						},
						new MenuItem
						{
							Area = "Admin",
							Action = "Index",
							Controller = "User",
							DisplayText = "Quản lý tài khoản",
							Icon = "fa-user",
							Permission = AuthConst.AppUser.VIEW_LIST,
						}
					}
				},
				new MenuItem
				{
					DisplayText = "Quản lý sản phẩm",
					Icon = "fa-shopping-basket",
					ChildrenItems = new MenuItem[]
					{
						new MenuItem
						{
							Area = "Admin",
							Action = "Index",
							Controller = "Product",
							DisplayText = "Quản lý sản phẩm",
							Icon = "fa-yin-yang",
							Permission = AuthConst.AppProductCategory.VIEW_LIST,
						},
						new MenuItem
						{
							Area = "Admin",
							Action = "Index",
							Controller = "ProductCategory",
							DisplayText = "Quản lý danh mục",
							Icon = "fa-th-large",
							Permission = AuthConst.AppProductCategory.VIEW_LIST,
						},
						new MenuItem
						{
							Area = "Admin",
							Action = "Index",
							Controller = "MstProductBrand",
							DisplayText = "Quản lý thương hiệu",
							Icon = "fa-copyright",
							Permission = AuthConst.MstProductBrand.VIEW_LIST,
						},
						new MenuItem
						{
							Area = "Admin",
							Action = "Index",
							Controller = "AppDiscountCode",
							DisplayText = "Mã giảm giá",
							Icon = "fa-money-bill",
							Permission = AuthConst.AppDiscountCode.VIEW_LIST,
						},
						new MenuItem
						{
							Area = "Admin",
							Action = "Index",
							Controller = "MstProductColor",
							DisplayText = "Màu sản phẩm",
							Icon = "fa-palette",
							Permission = AuthConst.MstProductColor.VIEW_LIST,
						},
						new MenuItem
						{
							Area = "Admin",
							Action = "Index",
							Controller = "MstProductSize",
							DisplayText = "Quản lý size",
							Icon = "fa-layer-group",
							Permission = AuthConst.MstProductSize.VIEW_LIST,
						}
					}
				},
				new MenuItem
				{
					DisplayText = "Quản lý tin tức",
					Icon = "fa-newspaper",
					ChildrenItems = new MenuItem[]
					{
						new MenuItem
						{
							Area = "Admin",
							Action = "Index",
							Controller = "NewsCategory",
							DisplayText = "Thể loại tin tức",
							Icon = "fa-cubes",
							Permission = AuthConst.AppNewsCategory.VIEW_LIST
						},
						new MenuItem
						{
							Area = "Admin",
							Action = "Index",
							Controller = "News",
							DisplayText = "Quản lý tin tức",
							Icon = "fa-map",
							Permission = AuthConst.AppNews.VIEW_LIST
						}
					}
				},
				new MenuItem
				{
					DisplayText = "Quản lý cửa hàng",
					Icon = "fa-store",
					ChildrenItems = new MenuItem[]
					{
						new MenuItem
						{
							Area = "Admin",
							Action = "Index",
							Controller = "SystemEnv",
							DisplayText = "Thông tin cửa hàng",
							Icon = "fa-puzzle-piece",
							Permission = AuthConst.SystemEnv.VIEW_LIST,
						},
						new MenuItem
						{
							Area = "Admin",
							Action = "CompanyIntroduction",
							Controller = "AboutCompany",
							DisplayText = "Giới thiệu",
							Icon = "fa-eject",
							Permission = AuthConst.AppAboutCompany.VIEW_LIST,
						},
						new MenuItem
						{
							Area = "Admin",
							Action = "Index",
							Controller = "AppBranch",
							DisplayText = "Quản lý chi nhánh",
							Icon = "fa-code-branch",
							Permission = AuthConst.AppBranch.VIEW_LIST,
						},
						new MenuItem
						{
							Area = "Admin",
							Action = "Index",
							Controller = "AppSlider",
							DisplayText = "Slider",
							Icon = "fa-sliders-h",
							Permission = AuthConst.AppSlider.VIEW_LIST,
						},
						new MenuItem
						{
							Area = "Admin",
							Action = "Index",
							Controller = "AppPolicy",
							DisplayText = "Chính sách",
							Icon = "fa-shield-alt",
							Permission = AuthConst.AppPolicy.VIEW_LIST,
						}
					}
				},
				new MenuItem
				{
					Action = "Index",
					Controller = "FileManager",
					DisplayText = "Quản lý tệp",
					Icon = "fa-folder-open",
				},
			});
			return View(navBar);
		}
	}
}
