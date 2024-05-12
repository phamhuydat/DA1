using App.Data.Entities.Products;
using App.Web.Common;
using System;
using System.Collections.Generic;

namespace App.Web.Areas.Admin.ViewModels.Product
{
	public class ListItemProductVM : ListItemBaseVM
	{
		public string ProductCode { get; set; }
		public string ProductName { get; set; }
		public string Description { get; set; }
		public int View { get; set; }
		public int Sold { get; set; }
		public bool IsActive { get; set; }
		public int? CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string ImagePath { get; set; }
		public int? DisplayOrder { get; set; }
		public int? TotalOption { get; set; }
		public int? TotalQuantity { get; set; }

	}
}
