using FruitCommerceDemo.BLL.Models;
using System;
using Xunit;

namespace FruitCommerceDemo.BLL.Test
{
    public class ShoppingCarts
    {
        ContextBLL _ctx;
        public ShoppingCarts()
        {
            _ctx = new ContextBLL();
        }
        [Fact]
        public async void MixedBag()
        {
            ShoppingCart cart = await _ctx.ShoppingCarts.GetShoppingCartAsync(String.Format("Xunit Test: {0}", DateTime.Now.Ticks));
            await cart.AddProductByIdAsync(1);
            await cart.AddProductByIdAsync(2, 5);
            Assert.Equal(55.00M, cart.GetTotal());
        }
        [Fact]
        public async void MixedBagWithPromotion()
        {
            ShoppingCart cart = await _ctx.ShoppingCarts.GetShoppingCartAsync(String.Format("Xunit Test: {0}", DateTime.Now.Ticks));
            await cart.AddProductByIdAsync(1);
            await cart.AddProductByIdAsync(2, 5);
            await cart.AddCouponByCodeAsync("ORANGEUGR8");
            Assert.Equal(30.00M, cart.GetTotal());
            Assert.Equal(25.00M, cart.GetDiscountTotal());
        }
    }
}
