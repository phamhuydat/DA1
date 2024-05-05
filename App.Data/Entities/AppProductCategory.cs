using App.Data.Entities.Base;
using App.Data.Entities.Products;

namespace App.Data.Entities
{
    public class AppProductCategory : AppEntityBase
    {
        public AppProductCategory()
        {
            ChildCategories = new HashSet<AppProductCategory>();
            AppProducts = new HashSet<AppProduct>();
            AppSlider = new List<AppSlider>();
        }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int CateLevel { get; set; }
        public bool HasChild { get; set; }
        public string? Content { get; set; }
        public string? CoverImgPath { get; set; }
        public string? StampPath { get; set; }
        public int? ParentCateId { get; set; }

        public AppProductCategory ParentCategory { get; set; }
        public ICollection<AppProductCategory> ChildCategories { get; set; }
        public ICollection<AppProduct> AppProducts { get; set; }
        public ICollection<AppSlider> AppSlider { get; set; }
    }
}