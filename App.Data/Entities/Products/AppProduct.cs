using App.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities.Products
{
	public class AppProduct : AppSEOBase
	{
		public AppProduct()
		{
			AppProductImages = new HashSet<AppProductImage>();
			AppOrderDetails = new HashSet<AppOrderDetail>();
		}
		public string ProductName { get; set; }
		public string Description { get; set; }
		public string Slug { get; set; }
		public decimal Price { get; set; }
		public decimal? DiscountPrice { get; set; }
		public DateTime? DiscountFrom { get; set; }
		public DateTime? DiscountTo { get; set; }
		public bool IsActive { get; set; } // còn bán hay ko
		public string ProductCode { get; set; }
		public int? CategoryId { get; set; }
		public int? Ram {  get; set; }
		public int? Rom {  get; set; }
		public int? inch { get; set; }
		public int? IsMain { get; set; }
		
		public virtual AppProductCategory ProductCategory { get; set; }
		public virtual MstProductColor ProductColor { get; set; }
		public virtual ICollection<AppProductImage> AppProductImages { get; set; }
		public virtual ICollection<AppOrderDetail> AppOrderDetails { get; set; }
	}
}
