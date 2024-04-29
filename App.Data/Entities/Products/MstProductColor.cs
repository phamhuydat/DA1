using App.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities.Products
{
    public class MstProductColor : MstEntityBase
    {
        public MstProductColor()
        {
            AppProdcutDetails = new HashSet<AppProductDetail>();
        }
        public string ColorName { get; set; }
        public string CssColor { get; set; }
        public virtual ICollection<AppProductDetail> AppProdcutDetails { get; set; }
    }
}
