using App.Share.Consts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using App.Shared.Attributes;

namespace App.Web.Areas.Admin.ViewModels.Product
{
	public class AddOrUpProOptionVM : ListItemBaseVM
	{
		public string Description { get; set; }
		[AppRequired]
		[DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
		public decimal Price { get; set; }

		public int ProductId { get; set; }
		[DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
		public decimal? DiscountPrice { get; set; }
		[AppRequired]
		public int ColorId { get; set; }

		public DateTime? DiscountTo { get; set; }
		public DateTime? DiscountFrom { get; set; }
		[AppRequired]
		[AppMaxLength(100)]
		public string ProductCode { get; set; }
		public string? Ram { get; set; }
		[AppRequired]
		public string Rom { get; set; }
		[AppRequired]
		public string Inch { get; set; }
		public int InStock { get; set; }
		public string? CPU { get; set; }
		public string? GPU { get; set; }
	}
}
