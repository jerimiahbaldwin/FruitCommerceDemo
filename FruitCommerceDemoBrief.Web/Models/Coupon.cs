using FruitCommerceDemoBrief.Web.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitCommerceDemoBrief.Web.Models
{
    public class Coupon : ICoupon
    {
        public int CouponId { get; set; }
        public string Code { get; set; }
        public decimal DiscountPercent { get; set; }
        public IEnumerable<int> AppliesToProductIds { get; set; }
    }
}
