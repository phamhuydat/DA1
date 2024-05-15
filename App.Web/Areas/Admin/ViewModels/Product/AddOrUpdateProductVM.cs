using App.Share.Consts;
using App.Shared.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using App.Data.Entities.Products;

namespace App.Web.Areas.Admin.ViewModels.Product
{
	public class AddOrUpdateProductVM : ListItemBaseVM
	{
		public AddOrUpdateProductVM()
		{
			AppProductImages = new HashSet<AppProductImage>();
		}
		[AppRequired]
		[AppMaxLength(DB.AppProduct.PRODUCTNAME_LENGTH)]
		public string ProductName { get; set; }
		public string Description { get; set; }
		[AppRequired]
		public int? CategoryId { get; set; }
		public string? LinkImage1 { get; set; }
		public string? LinkImage2 { get; set; }
		public string? LinkImage3 { get; set; }
		public string? LinkImage4 { get; set; }
		public string? LinkImage5 { get; set; }
		public string? LinkImage6 { get; set; }
		[AppRequired]
		[AppMaxLength(100)]
		public string ProductCode { get; set; }
		public ICollection<AppProductImage> AppProductImages { get; set; }
	}
}
