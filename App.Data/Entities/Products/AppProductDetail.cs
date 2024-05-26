using App.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities.Products
{
    public class AppProductDetail : AppEntityBase
    {
        public AppProductDetail()
        {
            AppOrderDetails = new HashSet<AppOrderDetail>();
        }
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
        public DateTime? DiscountFrom { get; set; }
        public DateTime? DiscountTo { get; set; }
        public int? ProductId { get; set; }
        public int? ColorId { get; set; }
        public string? Ram { get; set; }
        public string? Rom { get; set; }
        public string? CPU { get; set; }
        public string? GPU { get; set; }
        public bool? IsMain { get; set; }
        public int InStock { get; set; }
        public string? Inch { get; set; }
        public int Sold { get; set; }


        public virtual AppProduct AppProduct { get; set; }
        public virtual MstProductColor MstProductColor { get; set; }
        public virtual ICollection<AppOrderDetail> AppOrderDetails { get; set; }
    }
}
