using System;

namespace App.Web.Areas.Admin.ViewModels.Product.MstProductSize
{
	public class ProductSizeListItemVM : ListItemBaseVM
	{
		public string SizeCode { get; set; }
		public DateTime? CreatedDate { get; set; }
	}
}
