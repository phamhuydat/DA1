using DNews.Shared.Attributes;
using System;

namespace App.Web.Areas.Admin.ViewModels.AppSlider
{
	public class AddOrUpdateSliderVM
	{
		public int Id { get; set; }
		[AppRequired]
		public string ImagePath { get; set; }
		public DateTime? FromDate { get; set; }
		public DateTime? ToDate { get; set; }
		public string Link { get; set; }
	}
}
