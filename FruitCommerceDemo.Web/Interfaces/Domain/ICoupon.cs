
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitCommerceDemo.Web.Interfaces.Domain
{
    public interface ICoupon
    {
        int CouponId { get; set; }
        string Code { get; set; }
        decimal DiscountPercent { get; set; }
        IEnumerable<int> AppliesToProductIds { get; set; }
    }
}
