using GeekShopping.OrderAPI.Model;
using System.Threading.Tasks;

namespace GeekShopping.CartAPI.Repository
{
    public interface IOrderRepository
    {
        Task<bool> AddOrder(OrderHeader header);
        Task UpdateOrderPaymentStatus(long orderHeaderId, bool paid);
    }
}
