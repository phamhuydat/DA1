using System;

namespace App.Web.Areas.Admin.ViewModels.MstProductColor
{
	public class ProductColorListItemVM : ListItemBaseVM
	{
		public string ColorName { get; set; }
		public string CssColor { get; set; }
		public DateTime? CreatedDate { get; set; }
		public int CountProduct { get; set; }
	}
}
