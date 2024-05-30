using App.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
	// mã giảm giá
	public class AppVoucher : AppEntityBase
	{
		public AppVoucher()
		{
			AppOrders = new HashSet<AppOrder>();
		}
		public string Code { get; set; } // mã
		public int? Amount { get; set; } // số lượng mã 
		public decimal? Price { get; set; }  // mức giá đc giảm tối đa
		public decimal? Percent { get; set; } // biểu thị số % đc giảm giá theo % trên tổng giá trị đơn hàng
		public DateTime? StartDate { get; set; } // tg bắt đầu chương trình giảm giá
		public DateTime? EndDate { get; set; } //tg kết thúc chương trình giảm giá
		public int? UnApplyCategoryId { get; set; }
		public virtual ICollection<AppOrder> AppOrders { get; set; }
	}
}
