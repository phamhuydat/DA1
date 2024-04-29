using DNews.Shared.Attributes;

namespace App.Web.Areas.Admin.ViewModels.AppBranch
{
	public class AddOrUpdateBranchVM
	{
		public int Id { get; set; }
		[AppRequired]
		public string Address { get; set; }
	}
}
