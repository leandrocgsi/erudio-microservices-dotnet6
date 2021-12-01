using GeekShopping.CouponAPI.Data.ValueObjects;
using System.Threading.Tasks;

namespace GeekShopping.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponVO> GetCouponByCouponCode(string couponCode); 
    }
}
