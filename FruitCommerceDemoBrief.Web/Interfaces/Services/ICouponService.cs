using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FruitCommerceDemoBrief.Web.Interfaces.Domain;

namespace FruitCommerceDemoBrief.Web.Interfaces.Services
{
    public interface ICouponService
    {
        Task<IEnumerable<ICoupon>> GetAllAsync();
        Task<ICoupon> GetAsync(int couponId);
        Task<ICoupon> GetByCodeAsync(string couponCode);

    }
}
