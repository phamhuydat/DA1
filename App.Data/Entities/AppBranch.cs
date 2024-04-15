using App.Data.Entities.Base;

namespace App.Data.Entities
{ 
	public class AppBranch : AppEntityBase
	{
		// đại chỉ cửa hàng
		public string GroupName { get; set; }
		public string Address { get; set; }
		public string IdMap { get; set; }
	}
}
