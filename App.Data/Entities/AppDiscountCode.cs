using App.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{ 
	// mã giảm giá
	public class AppDiscountCode : AppEntityBase
	{
		public AppDiscountCode()
		{
			AppOrders = new HashSet<AppOrder>();
		}
		public string Code {get; set;}
		public decimal? DiscountPrice {get; set;}
		public decimal? MinDiscountPrice {get; set;}
		public string Description {get; set;}
		public int? UnApplyCategoryId { get; set; }
		public virtual ICollection<AppOrder> AppOrders { get; set; }
	}
}
