using App.Shared.Attributes;
using System.ComponentModel.DataAnnotations;

namespace App.Web.Areas.Admin.ViewModels.AppDiscountCode
{
    public class AddOrUpdateDiscountCodeVM
    {
        public int Id { get; set; }
        [AppRequired]
        public string Code { get; set; }
        [AppRequired]
        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        public decimal? DiscountPrice { get; set; }
        [AppRequired]
        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        public decimal? MinDiscountPrice { get; set; }
        public int? UnApplyCategoryId { get; set; }
    }
}
