using App.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities.Products
{
    public class AppProduct : AppEntityBase
    {
        public AppProduct()
        {
            AppProductImages = new HashSet<AppProductImage>();
            AppProductDetails = new HashSet<AppProductDetail>();
        }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } // còn bán hay ko 
        public string ProductCode { get; set; }
        public int? CategoryId { get; set; }

        public virtual AppProductCategory AppProdcutCategory { get; set; }
        public virtual ICollection<AppProductImage> AppProductImages { get; set; }
        public virtual ICollection<AppProductDetail> AppProductDetails { get; set; }

    }
}
