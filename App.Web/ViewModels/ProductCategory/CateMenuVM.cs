using App.Data.Entities;
using System.Collections.Generic;

namespace App.Web.ViewModels.ProductCategory
{
	public class CateMenuVM
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Slug { get; set; }
		public int CateLevel { get; set; }
		public bool HasChild { get; set; }
		public string GroupName { get; set; }
		public ICollection<AppProductCategory> ChildCategories { get; set; }
	}
}
