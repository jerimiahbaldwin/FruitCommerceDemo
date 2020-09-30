using FruitCommerceDemoBrief.Web.Interfaces.Services;
using FruitCommerceDemoBrief.Web.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FruitCommerceDemoBrief.Web.Data;

namespace FruitCommerceDemoBrief.Web.Services
{
    public class CouponService : ICouponService
    {
        private readonly List<ICoupon> _coupons;
        public CouponService(IProductService productService)
        {
            _coupons = new CouponRepository(productService);
        }
        public async Task<ICoupon> GetAsync(int couponId)
        {
            // TODO: Remove this demonstration wait.
            await Task.Delay(3000);
            return _coupons.Find(o => o.CouponId == couponId);
        }

        public async Task<IEnumerable<ICoupon>> GetAllAsync()
        {
            // TODO: Remove this demonstration wait.
            await Task.Delay(2000);
            return _coupons;
        }

        public async Task<ICoupon> GetByCodeAsync(string couponCode)
        {
            // TODO: Remove this demonstration wait.
            await Task.Delay(3000);
            return _coupons.Find(o => o.Code == couponCode);
        }
    }
}
