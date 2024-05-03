using App.Shared.Attributes;

namespace App.Web.Areas.Admin.ViewModels.Product.MstProductSize
{
    public class AddOrUpdateProductSizeVM
    {
        public int Id { get; set; }
        [AppRequired]
        public string SizeCode { get; set; }
    }
}
