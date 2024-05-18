using System;

namespace App.Web.Areas.Admin.ViewModels.AppSlider
{
	public class SliderListItemVM : ListItemBaseVM
	{
		public string ImagePath { get; set; }
		public DateTime? FromDate { get; set; }
		public DateTime? ToDate { get; set; }
		public string Link { get; set; }
		public string CategoryName { get; set; }
	}
}
