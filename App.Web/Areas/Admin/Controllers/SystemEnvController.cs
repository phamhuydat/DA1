using App.Share.Consts;
using App.Web.Common;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace App.Web.Areas.Admin.Controllers
{
	public class SystemEnvController : AppControllerBase
	{
		private readonly SystemEnvironment _sysEnv;
		public SystemEnvController(IMapper mapper, SystemEnvironment sysEnv) : base(mapper)
		{
			_sysEnv = sysEnv;
		}
		[AppAuthorize]
		public IActionResult Index()
		{
			return View(_sysEnv);
		}
		[AppAuthorize(AuthConst.SystemEnv.UPDATE)]
		[HttpPost]
		public IActionResult Update(Dictionary<string, string> model)
		{
			foreach (var item in model)
			{
				_sysEnv.UpdateSysEnv(item.Key, item.Value);
			}
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}
	}
}
