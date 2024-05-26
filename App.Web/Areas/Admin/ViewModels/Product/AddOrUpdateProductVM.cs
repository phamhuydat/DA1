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

        [AppRequired]
        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }

        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        public decimal? DiscountPrice { get; set; }
        [AppRequired]
        public int ColorId { get; set; }

        public DateTime? DiscountTo { get; set; }
        public DateTime? DiscountFrom { get; set; }

        public string? Ram { get; set; }
        public string? Rom { get; set; }
        [AppRequired]
        public string? Inch { get; set; }
        [AppRequired]
        public int InStock { get; set; }
        public string? CPU { get; set; }
        public string? GPU { get; set; }
        public ICollection<AppProductImage> AppProductImages { get; set; }
    }
}
