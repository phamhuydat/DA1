using App.Web.Common;

namespace App.Web.Areas.Admin.ViewModels.Product
{
	public class ListOptionVM : ListItemBaseVM
	{
		public string ProductCode { get; set; }
		public string ProductName { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public decimal? DiscountPrice { get; set; }
		public DateTime? DiscountFrom { get; set; }
		public DateTime? DiscountTo { get; set; }
		public int InStock { get; set; }
		public int InStockMin { get; set; }
		public int View { get; set; }
		public int Sold { get; set; }
		public bool IsActive { get; set; }
		public int? CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string BrandName { get; set; }
		public string ColorName { get; set; }
		public string ColorCss { get; set; }
		public string ImagePath { get; set; }
		public int? DisplayOrder { get; set; }
		public int? ProductId { get; set; }
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
