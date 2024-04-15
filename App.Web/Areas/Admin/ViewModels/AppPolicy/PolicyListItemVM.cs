namespace App.Web.Areas.Admin.ViewModels.AppPolicy
{
	public class PolicyListItemVM : ListItemBaseVM
	{
		public string Title { get; set; }
		public string Slug { get; set; }
		public string CoverImgPath { get; set; }
		public string CoverImgThumbnailPath { get; set; }
		public string Content { get; set; }
		public int Like { get; set; }
	}
}
