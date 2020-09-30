using System.Threading.Tasks;
using FruitCommerceDemo.Core.Interfaces.DTO;
using FruitCommerceDemo.BLL.Models;

namespace FruitCommerceDemo.BLL.Services
{
    public class CouponService
    {
        private readonly ContextBLL _contextBLL;
        private CouponService() { } // hide constructor
        public CouponService(ContextBLL contextBLL)
        {
            _contextBLL = contextBLL;
        }
        public async Task<Coupon> GetByCodeAsync(string couponCode)
        {
            // TODO: Remove this demonstration wait.
            await Task.Delay(3000);
            ICouponDTO dto = await _contextBLL.DAL.Coupons.GetCouponByCodeAsync(couponCode);
            return new Coupon(dto);
        }
    }
}
