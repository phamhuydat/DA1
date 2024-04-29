using App.Data.Entities.Base;
using App.Data.Entities.Products;

namespace App.Data.Entities
{
    public class AppProductCategory : AppEntityBase
    {
        public AppProductCategory()
        {
            //childcategories = new hashset<appproductcategory>();
            AppProducts = new HashSet<AppProduct>();
        }
        public string Name { get; set; }

        public virtual ICollection<AppProduct> AppProducts { get; set; }
        public virtual ICollection<AppSlider> AppSlider { get; set; }
    }
}