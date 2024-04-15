﻿using App.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
	public class MstOrderStatus : MstEntityBase
	{
		public MstOrderStatus()
		{
			AppOrders = new HashSet<AppOrder>();
		}
		public string Name { get; set; }
		public ICollection<AppOrder> AppOrders { get; set; }
	}
}
