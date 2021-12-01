namespace GeekShopping.Web.Models
{
    public class CartDetailViewModel
    {
        public long Id { get; set; }
        public long CartHeaderId { get; set; }
        public CartHeaderViewModel CartHeader { get; set; }
        public long ProductId { get; set; }
        public ProductViewModel Product { get; set; }

        public int Count { get; set; }
    }
}
