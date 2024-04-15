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
            AppProducts = new HashSet<AppProduct>();
		}
		public string ColorName { get; set; }
		public string CssColor { get; set; }
		public virtual ICollection<AppProduct> AppProducts { get; set; }
	}
}
