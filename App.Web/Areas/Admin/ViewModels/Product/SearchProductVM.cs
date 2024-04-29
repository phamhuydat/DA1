namespace App.Web.Areas.Admin.ViewModels.Product
{
	public class SearchProductVM
	{
		public string ProductName { get; set; }
		public int? CateId { get; set; }
		public int? BrandId { get; set; }
		public int? ColorId { get; set; }
		public int? SizeId { get; set; }
		public bool? IsDiscount { get; set; }
	}
}
