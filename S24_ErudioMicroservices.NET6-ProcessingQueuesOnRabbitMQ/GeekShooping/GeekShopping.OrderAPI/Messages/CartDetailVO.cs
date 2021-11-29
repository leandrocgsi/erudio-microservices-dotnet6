namespace GeekShopping.OrderAPI.Messages
{
    public class CartDetailVO
    {
        public long Id { get; set; }
        public long CartHeaderId { get; set; }
        public long ProductId { get; set; }
        public virtual ProductVO Product { get; set; }

        public int Count { get; set; }
    }
}
