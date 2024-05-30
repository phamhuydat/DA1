using App.Shared.Attributes;
using System.ComponentModel;
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
        public decimal? Price { get; set; }
        [AppRequired]
        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        public decimal? Percent { get; set; }
        public int? UnApplyCategoryId { get; set; }
        [DisplayName("Ngày bắt đầu")]
        public DateTime? StartDate { get; set; }
        [DisplayName("Ngày kết thúc")]
        public DateTime? EndDate { get; set; }
    }
}
