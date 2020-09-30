using System.Collections.Generic;

namespace FruitCommerceDemo.Core.Interfaces.DTO
{
    public interface ICouponDTO
    {
        int CouponId { get; set; }
        string Code { get; set; }
        decimal DiscountPercent { get; set; }
        IEnumerable<int> AppliesToProductIds { get; set; }
    }
}
