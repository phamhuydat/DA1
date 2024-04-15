using App.Web.Common;
using System;

namespace App.Web.ViewModels.Product
{
	public class ProductListVM : SEOBaseVM
	{
		public string ProductName { get; set; }
		public string Description { get; set; }
		public string Slug { get; set; }
		public string StampPath { get; set; }
		public decimal Price { get; set; }
		public decimal? DiscountPrice { get; set; }
		public DateTime? DiscountFrom { get; set; }
		public DateTime? DiscountTo { get; set; }
		public bool IsActive { get; set; }
		public string ImagePath { get; set; }
		public string ProductCode { get; set; }
		public string TagProduct { get; set; }
		public int DisplayOrder { get; set; }
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
