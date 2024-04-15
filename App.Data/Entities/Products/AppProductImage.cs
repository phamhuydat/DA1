using App.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities.Products
{
	public class AppProductImage : AppEntityBase
	{
		public string ImagePath { get; set; }
		public int? ProductId { get; set; }
		public AppProduct Product { get; set; }
	}
}
