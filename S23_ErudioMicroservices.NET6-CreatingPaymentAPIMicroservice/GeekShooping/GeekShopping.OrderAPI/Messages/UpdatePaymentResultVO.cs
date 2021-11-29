namespace GeekShopping.OrderAPI.Messages
{
    public class UpdatePaymentResultVO
    {
        public long OrderId { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
    }
}
