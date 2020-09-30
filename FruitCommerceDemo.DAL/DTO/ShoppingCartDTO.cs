using System.Collections.Generic;
using System.Linq;
using FruitCommerceDemo.Core.Interfaces.DTO;
using FruitCommerceDemo.EF.Entities;

namespace FruitCommerceDemo.DAL.DTO
{
    public class ShoppingCartDTO : IShoppingCartDTO
    {
        public ShoppingCartDTO(ShoppingCart cart)
        {
            ShoppingCartId = cart.ShoppingCartId;
            SessionId = cart.SessionId;
            Items = (cart.Items ?? new List<ShoppingCartItem>()).Select(o => new ShoppingCartItemDTO(o));
            Coupons = (cart.Coupons ?? new List<ShoppingCartCoupon>()).Select(o => new CouponDTO(o.Coupon));
        }
        public int ShoppingCartId { get; set; }
        public string SessionId { get; set; }
        public IEnumerable<IShoppingCartItemDTO> Items { get; set; }
        public IEnumerable<ICouponDTO> Coupons { get; set; }
    }
}
