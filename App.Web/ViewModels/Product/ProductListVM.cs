using App.Data.Entities.Base;
using App.Web.Common;
using System;

namespace App.Web.ViewModels.Product
{
    public class ProductListVM : AppEntityBase
    {
        public int id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
        public DateTime? DiscountFrom { get; set; }
        public DateTime? DiscountTo { get; set; }
        public bool IsActive { get; set; }
        public string ImagePath { get; set; }
        public string ProductCode { get; set; }
        public int DisplayOrder { get; set; }
        public int? CategoryId { get; set; }
        public bool IsMain { get; set; }

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
