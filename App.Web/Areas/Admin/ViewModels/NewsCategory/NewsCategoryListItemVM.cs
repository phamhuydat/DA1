namespace App.Web.Areas.Admin.ViewModels.NewsCategory
{
	public class NewsCategoryListItemVM : ListItemBaseVM
	{
		public string Title { get; set; }
		public string Slug { get; set; }
		public string Content { get; set; }
		public string CoverImgPath { get; set; }
		public int TotalNews { get; set; }
	}
}
