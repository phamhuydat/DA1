using System.ComponentModel;

namespace App.Web.Areas.Admin.ViewModels.AppDiscountCode
{
    public class DiscountCodeListItemVM : ListItemBaseVM
    {
        public string Code { get; set; }
        public decimal? Price { get; set; }
        public decimal? Percent { get; set; }
        public string Description { get; set; }
        public int? UnApplyCategoryId { get; set; }
        public string GroupNameCategory { get; set; }
        [DisplayName("Ngày bắt đầu")]
        public DateTime StartDate { get; set; }
        [DisplayName("Ngày kết thúc")]
        public DateTime EndDate { get; set; }
    }
}
