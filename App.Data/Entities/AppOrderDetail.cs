using App.Data.Entities.Base;
using App.Data.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
	public class AppOrderDetail : AppEntityBase
	{
		public int? OrderId { get; set; }
		public int? ProductId { get; set; }
		public string ProductName { get; set; }
		public decimal Price { get; set; }
		public int? Quantity { get; set; }
		public decimal ProductPrice { get; set; }
		public string ImagePath { get; set; }
		public AppOrder AppOrder { get; set; }
		public AppProductDetail AppProductDetail { get; set; }
	}
}
