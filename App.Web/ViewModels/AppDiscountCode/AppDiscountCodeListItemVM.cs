namespace App.Web.ViewModels.AppDiscountCode
{
	public class AppDiscountCodeListItemVM
	{
		public string Code { get; set; }
		public decimal? DiscountPrice { get; set; }
		public decimal? MinDiscountPrice { get; set; }
		public string Description { get; set; }
		public int? UnApplyCategoryId { get; set; }
		public string GroupNameCategory { get; set; }
	}
}
