using GeekShopping.CartAPI.Data.ValueObjects;
using System.Threading.Tasks;

namespace GeekShopping.CartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponVO> GetCoupon(string couponCode, string token); 
    }
}
