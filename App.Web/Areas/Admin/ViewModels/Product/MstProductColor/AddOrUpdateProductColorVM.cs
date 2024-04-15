using DNews.Shared.Attributes;

namespace App.Web.Areas.Admin.ViewModels.MstProductColor
{
	public class AddOrUpdateProductColorVM
	{
		public int Id { get; set; }
		[AppRequired]
		public string ColorName { get; set; }
	}
}
