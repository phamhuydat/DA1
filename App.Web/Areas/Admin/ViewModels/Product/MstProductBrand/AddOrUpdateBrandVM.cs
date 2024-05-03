using App.Shared.Attributes;

namespace App.Web.Areas.Admin.ViewModels.MstProductBrand
{
    public class AddOrUpdateBrandVM
    {
        public int Id { get; set; }
        [AppRequired]
        public string Name { get; set; }
        [AppRequired]
        public string ImagePath { get; set; }
    }
}
