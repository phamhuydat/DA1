using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace App.Web.ViewModels.FilterMenu
{
	public class FilterMenuViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
