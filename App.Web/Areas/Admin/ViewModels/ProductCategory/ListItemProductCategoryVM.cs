using App.Data.Entities;
using App.Data.Entities.Products;
using System;
using System.Collections.Generic;

namespace App.Web.Areas.Admin.ViewModels.ProductCategory
{
	public class ListItemProductCategoryVM : ListItemBaseVM
	{
		public string Name { get; set; }
		public int CateLevel { get; set; }
		public bool HasChild { get; set; }
		public string? CoverImgPath { get; set; }
		public string? StampPath { get; set; }
		public int? ParentCateId { get; set; }
		public int? DisplayOrder { get; set; }
		public DateTime? DeletedDate { get; set; }
		public ICollection<AppProductCategory> ChildCategories { get; set; }
		public AppProductCategory ParentCategory { get; set; }
		public ICollection<AppProduct> AppProducts { get; set; }
	}
}
