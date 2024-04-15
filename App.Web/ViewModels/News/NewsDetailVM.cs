using System;

namespace App.Web.ViewModels.News
{
	public class NewsDetailVM : SEOBaseVM
	{
		public string Title { get; set; }
		public string Slug { get; set; }
		public string Summary { get; set; }
		public string Content { get; set; }
		public long Views { get; set; }
		public float Votes { get; set; }
		public bool Published { get; set; }
		public DateTime? PublishedAt { get; set; }
		public string CoverImgPath { get; set; }
		public DateTime? CreatedDate { get; set; }
		public string CreatedBy { get; set; }
	}
}
