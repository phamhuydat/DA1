using App.Data.Entities.Base;
using App.Data.Entities.Products;
using App.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.Web.ViewModels.Product
{
    public class ProductDetailClientVM : AppEntityBase
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
        public int? CategoryId { get; set; }
        public int? ProductColorId { get; set; }
        public DateTime? DiscountTo { get; set; }
        public DateTime? DiscountFrom { get; set; }
        public string ProductCode { get; set; }
        public string CategoryName { get; set; }
        public string ColorName { get; set; }

        public ICollection<AppProductImage> AppProductImages { get; set; }
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
