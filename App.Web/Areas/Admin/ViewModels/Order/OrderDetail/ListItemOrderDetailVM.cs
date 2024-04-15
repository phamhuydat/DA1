namespace App.Web.Areas.Admin.ViewModels.Order.OrderDetail
{
	public class ListItemOrderDetailVM : ListItemBaseVM
	{
		public int OrderId { get; set; }
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public decimal Price { get; set; }
		public int? Quantity { get; set; }
		public decimal ProductPrice { get; set; }
		public string? ImagePath { get; set; }
	}
}
