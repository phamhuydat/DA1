using App.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
	public class AppVerifyCode : AppEntityBase
	{
		// mã xác thực
		public string TokenString { get; set; }
		public DateTime Expired { get; set; }
		public bool IsVerified { get; set; }
		public int? UserId { get; set; }
		public AppUser AppUser { get; set; }
	}
}
