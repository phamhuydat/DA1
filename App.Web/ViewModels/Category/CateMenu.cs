namespace App.Web.ViewModels.Category
{
    public class CateMenu
    {
        public CateMenu()
        {
            Childs = new HashSet<CateMenu>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public ICollection<CateMenu> Childs { get; set; }
    }
}
