using App.Web.Common;
using System;

namespace App.Web.ViewModels.Cart
{
    public class CartItemVM
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
        public DateTime? DiscountFrom { get; set; }
        public DateTime? DiscountTo { get; set; }
        public bool IsActive { get; set; }
        public string ImagePath { get; set; }
        public string CategoryName { get; set; }
        public int Quantity { get; set; }
        public string ProductCode { get; set; }
        public string ColorName { get; set; }
        public string? Ram { get; set; }
        public string? Rom { get; set; }
        public decimal FinalPrice
        {
            get
            {
                var now = DateTime.Now;
                var price = this.Price;
                var d1 = this.DiscountFrom ?? DateTime.MinValue;
                var d2 = this.DiscountTo ?? DateTime.MaxValue;
                if (this.DiscountPrice.HasValue && now.IsBetween(d1, d2))
                {
                    price = this.DiscountPrice.Value;
                }
                return price;
            }
        }
    }
}
