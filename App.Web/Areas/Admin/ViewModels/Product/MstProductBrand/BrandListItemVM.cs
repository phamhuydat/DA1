namespace App.Web.Areas.Admin.ViewModels.MstProductBrand
{
	public class BrandListItemVM : ListItemBaseVM
	{
		public string Name { get; set; }
		public string ImagePath { get; set; }
		public string Slug { get; set; }
		public int CountProduct { get; set; }
	}
}
