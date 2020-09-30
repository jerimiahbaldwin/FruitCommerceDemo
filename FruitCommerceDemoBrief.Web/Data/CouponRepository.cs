using FruitCommerceDemoBrief.Web.Interfaces.Domain;
using FruitCommerceDemoBrief.Web.Interfaces.Services;
using FruitCommerceDemoBrief.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitCommerceDemoBrief.Web.Data
{
    public class CouponRepository : List<ICoupon>
    {
        public CouponRepository(IProductService productService)
        {
            // TODO: These should be pulled from DB.
            this.Add(new Coupon
            {
                CouponId = 1,
                Code = "ORANGEUGR8",
                DiscountPercent = .5M,
                AppliesToProductIds = new[] { 2 },
            });
        }
    }
}
