using System;
using System.Threading.Tasks;
using FruitCommerceDemo.Core.Interfaces.DataProviders;
using FruitCommerceDemo.Core.Interfaces.DTO;
using Microsoft.EntityFrameworkCore;
using FruitCommerceDemo.EF.Entities;
using System.Linq;
using FruitCommerceDemo.DAL.DTO;

namespace FruitCommerceDemo.DAL.DataProviders
{
    public class CouponDataProvider : ICouponDataProvider
    {
        private readonly ContextDAL _contextDAL;
        private CouponDataProvider() { }
        public CouponDataProvider(ContextDAL contextDAL)
        {
            _contextDAL = contextDAL;
        }
        public async Task<ICouponDTO> GetCouponByCodeAsync(string couponCode)
        {
            return new CouponDTO(await _contextDAL._dbContext.Coupons.FirstOrDefaultAsync(o => o.Code == couponCode));
        }
    }
}
