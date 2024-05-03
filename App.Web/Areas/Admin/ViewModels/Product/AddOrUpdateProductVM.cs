using App.Share.Consts;
using App.Shared.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using App.Data.Entities.Products;

namespace App.Web.Areas.Admin.ViewModels.Product
{
    public class AddOrUpdateProductVM : SEOEntityBaseVM
    {
        public AddOrUpdateProductVM()
        {
            AppProductImages = new HashSet<AppProductImage>();
        }
        [AppRequired]
        [AppMaxLength(DB.AppProduct.PRODUCTNAME_LENGTH)]
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string StampPath { get; set; }
        [AppRequired]
        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }

        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        public decimal? DiscountPrice { get; set; }

        [AppRequired]
        public int? BrandId { get; set; }
        [AppRequired]
        public int? CategoryId { get; set; }
        [AppRequired]
        public int? ProductColorId { get; set; }

        public DateTime? DiscountTo { get; set; }
        public DateTime? DiscountFrom { get; set; }
        public string? LinkImage1 { get; set; }
        public string? LinkImage2 { get; set; }
        public string? LinkImage3 { get; set; }
        public string? LinkImage4 { get; set; }
        public string? LinkImage5 { get; set; }
        public string? LinkImage6 { get; set; }
        [AppRequired]
        [AppMaxLength(100)]
        public string ProductCode { get; set; }
        public string TagProduct { get; set; }
        public ICollection<AppProductImage> AppProductImages { get; set; }
    }
}
