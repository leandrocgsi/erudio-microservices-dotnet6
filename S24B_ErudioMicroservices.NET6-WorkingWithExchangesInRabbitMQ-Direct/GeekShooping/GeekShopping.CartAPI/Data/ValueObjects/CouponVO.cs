namespace GeekShopping.CartAPI.Data.ValueObjects
{
    public class CouponVO
    {
        public long Id { get; set; }
        public string CouponCode { get; set; }
        public decimal DiscountAmount { get; set; }
    }
}
