using App.Web.Common;
using System.Runtime.CompilerServices;

namespace App.Web.Areas.Admin.ViewModels.Product
{
	public class ListOptionVM : ListItemBaseVM
	{
		public string ProductName { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public decimal? DiscountPrice { get; set; }
		public DateTime? DiscountFrom { get; set; }
		public DateTime? DiscountTo { get; set; }
		public int InStock { get; set; }
		public int Sold { get; set; }
		public bool IsActive { get; set; }
		public string ColorName { get; set; }
		public string ColorCss { get; set; }
		public string ImagePath { get; set; }
		public int? DisplayOrder { get; set; }
		public string? Ram { get; set; }
		public string? Rom { get; set; }
		public string? Inch { get; set; }
		public string? CPU { get; set; }
		public bool IsDiscountProduct
		{
			get
			{
				var now = DateTime.Now;
				var d1 = this.DiscountFrom ?? DateTime.MinValue;
				var d2 = this.DiscountTo ?? DateTime.MaxValue;

				if (this.DiscountPrice.HasValue)
				{
					return now.IsBetween(d1, d2);
				}
				return false;
			}
		}
	}
}
