using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitCommerceDemo.Web.Interfaces.Domain
{
    public interface IShoppingCart
    {
        Task<IShoppingCartItem> AddProductAsync(IProduct product, int quantity = 1);
        Task<IShoppingCartItem> AddProductByIdAsync(int productId, int quantity = 1);
        Task RemoveProductByIdAsync(int productId);
        Task SetQuantityByProductIdAsync(int productId, int quantity);
        Task AddCouponByCodeAsync(string couponCode);
        Task AddCouponAsync(ICoupon coupon);
        Task RemoveCouponAsync(ICoupon coupon);
        Task RemoveCouponByCodeAsync(string couponCode);
        IEnumerable<IShoppingCartItem> Items { get; }
        IEnumerable<ICoupon> Coupons { get; }
        decimal GetSubtotal();
        decimal GetDiscountTotal();
        decimal GetTotal();
    }
}
