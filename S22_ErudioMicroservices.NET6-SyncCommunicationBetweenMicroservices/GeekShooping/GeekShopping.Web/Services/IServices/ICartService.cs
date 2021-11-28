using GeekShopping.Web.Models;
using System.Threading.Tasks;

namespace GeekShopping.Web.Services.IServices
{
    public interface ICartService
    {
        Task<CartViewModel> FindCartByUserId(string userId, string token);
        Task<CartViewModel> AddItemToCart(CartViewModel cart, string token);
        Task<CartViewModel> UpdateCart(CartViewModel cart, string token);
        Task<bool> RemoveFromCart(long cartId, string token);

        Task<bool> ApplyCoupon(CartViewModel cart, string token);
        Task<bool> RemoveCoupon(string userId, string token);
        Task<bool> ClearCart(string userId, string token);

        Task<object> Checkout(CartHeaderViewModel cartHeader, string token);
     }
}
