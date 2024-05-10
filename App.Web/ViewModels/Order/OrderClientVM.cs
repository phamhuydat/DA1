using Org.BouncyCastle.Bcpg.OpenPgp;

namespace App.Web.ViewModels.Order
{
    public class OrderClientVM
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Total { get; set; }
        public string? MethodPay { get; set; }
        public int Status { get; set; }
        public int CreatedBy { get; set; }
    }
}
