using App.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
	// thể loại tin tức
	public class AppNewsCategory : AppEntityBase
	{
		public AppNewsCategory()
		{
			NewsNavigation = new HashSet<AppNews>();
		}
		public string Title { get; set; }
		public string Slug { get; set; }
		public string? Content { get; set; }
		public string? CoverImgPath { get; set; }
		public ICollection<AppNews> NewsNavigation { get; set; }
	}
}
