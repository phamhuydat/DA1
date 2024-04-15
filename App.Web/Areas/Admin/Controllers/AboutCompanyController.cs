using App.Share.Consts;
using App.Web.Common;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace App.Web.Areas.Admin.Controllers
{
	public class AboutCompanyController : AppControllerBase
	{
		private readonly SystemEnvironment _sysEnv;

		public AboutCompanyController(IMapper mapper, SystemEnvironment sysEnv) : base(mapper)
		{
			_sysEnv = sysEnv;
		}
		[AppAuthorize(AuthConst.AppAboutCompany.VIEW_LIST)]
		public IActionResult CompanyIntroduction()
		{
			return View(_sysEnv);
		}
		[AppAuthorize(AuthConst.AppAboutCompany.UPDATE)]
		[HttpPost]
		public IActionResult CompanyIntroduction(Dictionary<string, string> model)
		{
			try
			{
				foreach (var item in model)
				{
					_sysEnv.UpdateSysEnv(item.Key, item.Value);
				}
				SetSuccessMesg("Cập nhật thông tin trang giới thiệu thành công!");
			}
			catch (Exception ex)
			{
				LogException(ex);
				SetErrorMesg("Đã xảy ra một lỗi. " + ex.Message);
			}
			return RedirectToAction(nameof(CompanyIntroduction));
		}
	}
}
