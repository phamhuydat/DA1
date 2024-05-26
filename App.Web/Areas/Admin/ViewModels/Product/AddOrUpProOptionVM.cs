using App.Share.Consts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using App.Shared.Attributes;

namespace App.Web.Areas.Admin.ViewModels.Product
{
    public class AddOrUpProOptionVM : ListItemBaseVM
    {
        //public string Description { get; set; }
        [AppRequired]
        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }

        public int ProductId { get; set; }
        public string ProductIdCode { get; set; }
        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        public decimal? DiscountPrice { get; set; }
        [AppRequired]
        public int ColorId { get; set; }

        public DateTime? DiscountTo { get; set; }
        public DateTime? DiscountFrom { get; set; }

        public string? Ram { get; set; }
        public string? Rom { get; set; }
        public string? Inch { get; set; }
        [AppRequired]

        public int InStock { get; set; }
        public string? CPU { get; set; }
        public string? GPU { get; set; }
    }
}
