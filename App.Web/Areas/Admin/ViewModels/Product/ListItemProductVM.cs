using App.Data.Entities.Products;
using App.Web.Common;
using System;
using System.Collections.Generic;

namespace App.Web.Areas.Admin.ViewModels.Product
{
    public class ListItemProductVM : ListItemBaseVM
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public string StampPath { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
        public DateTime? DiscountFrom { get; set; }
        public DateTime? DiscountTo { get; set; }
        public int InStock { get; set; }
        public int InStockMin { get; set; }
        public int View { get; set; }
        public int Sold { get; set; }
        public bool IsActive { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string ImagePath { get; set; }
        public int? DisplayOrder { get; set; }
        public bool IsDiscountProduct
        {
            get
            {
                var now = DateTime.Now;
                var d1 = this.DiscountFrom ?? DateTime.MinValue;
                var d2 = this.DiscountTo ?? DateTime.MaxValue;

                if (this.DiscountPrice.HasValue)
                {
                    return now.IsBetween(d1, d2);
                }
                return false;
            }
        }
    }
}
