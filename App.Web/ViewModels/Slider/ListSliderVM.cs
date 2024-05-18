using System;

namespace App.Web.ViewModels.Slider
{
	public class ListSliderVM
	{
		public string ImagePath { get; set; }
		public DateTime? FromDate { get; set; }
		public DateTime? ToDate { get; set; }
		public string Link { get; set; }
		public int? CategoryId { get; set; }
	}
}
