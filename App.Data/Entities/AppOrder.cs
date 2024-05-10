using App.Data.Entities.Base;

namespace App.Data.Entities
{
    // thông tin đặt hàng
    public class AppOrder : AppEntityBase
    {
        public AppOrder()
        {
            AppOrderDetails = new HashSet<AppOrderDetail>();
        }
        public string CusName { get; set; }
        public string CusPhone { get; set; }
        public string CusEmail { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal Total { get; set; }
        public int? StatusId { get; set; }
        public string? Voucher { get; set; }
        public int? EmployeeId { get; set; }
        public int? DiscountCodeId { get; set; }
        public string? MethodPay { get; set; }

        public AppUser Employee { get; set; }
        public AppUser Customer { get; set; }
        public MstOrderStatus MstOrderStatus { get; set; }
        public AppVoucher AppDiscountCode { get; set; }
        public virtual ICollection<AppOrderDetail> AppOrderDetails { get; set; }
    }
}
