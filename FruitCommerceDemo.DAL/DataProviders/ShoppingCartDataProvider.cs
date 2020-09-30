using System;
using System.Threading.Tasks;
using FruitCommerceDemo.Core.Interfaces.DataProviders;
using FruitCommerceDemo.Core.Interfaces.DTO;
using FruitCommerceDemo.EF.Entities;
using FruitCommerceDemo.DAL.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using System.Collections.Generic;

namespace FruitCommerceDemo.DAL.DataProviders
{
    public class ShoppingCartDataProvider : IShoppingCartDataProvider
    {
        private readonly ContextDAL _contextDAL;
        private ShoppingCartDataProvider() { }
        public ShoppingCartDataProvider(ContextDAL contextDAL)
        {
            _contextDAL = contextDAL;
        }
        public async Task<IShoppingCartDTO> GetShopppingCartBySessionIdAsync(string sessionId)
        {
            // TODO: Remove this demonstration wait.
            await Task.Delay(100);
            ShoppingCart cart = await _contextDAL._dbContext.ShoppingCarts.FirstOrDefaultAsync(o => o.SessionId == sessionId);
            if (cart == null)
            {
                EntityEntry<ShoppingCart> entry = await _contextDAL._dbContext.ShoppingCarts.AddAsync(new ShoppingCart()
                {
                    SessionId = sessionId,
                });
                await _contextDAL._dbContext.SaveChangesAsync();
                cart = entry.Entity;
            }
            return new ShoppingCartDTO(cart);
        }
        public async Task<IShoppingCartItemDTO> AddProductToCartAsync(string sessionId, int productId, int quantity = 1)
        {
            // TODO: Remove this demonstration wait.
            await Task.Delay(2000);
            ShoppingCart cart = await _contextDAL._dbContext.ShoppingCarts.FirstOrDefaultAsync(o => o.SessionId == sessionId);
            Product product = await _contextDAL._dbContext.Products.FirstOrDefaultAsync(o => o.ProductId == productId);
            ShoppingCartItem item = new ShoppingCartItem()
            {
                Product = product,
                Quantity = quantity,
            };
            if (cart.Items == null) cart.Items = new List<ShoppingCartItem>();
            cart.Items.Add(item);
            await _contextDAL._dbContext.SaveChangesAsync();
            return new ShoppingCartItemDTO(item);
        }
        public async Task RemoveProductFromCartAsync(string sessionId, int productId)
        {
            // TODO: Remove this demonstration wait.
            await Task.Delay(2000);
            ShoppingCart cart = await _contextDAL._dbContext.ShoppingCarts.FirstOrDefaultAsync(o => o.SessionId == sessionId);
            ShoppingCartItem item = cart.Items.FirstOrDefault(o => o.Product.ProductId == productId);
            if (item == null) throw new InvalidOperationException("That item is not in the shopping cart.");
            cart.Items.Remove(item);
            await _contextDAL._dbContext.SaveChangesAsync();
        }
        public async Task UpdateCartItemAsync(IShoppingCartItemDTO obj)
        {
            // TODO: Remove this demonstration wait.
            await Task.Delay(300);
            ShoppingCart cart = await _contextDAL._dbContext.ShoppingCarts.FirstOrDefaultAsync(o => o.ShoppingCartId == obj.ShoppingCartId);
            ShoppingCartItem item = cart.Items.FirstOrDefault(o => o.Product.ProductId == obj.Product.ProductId);
            item.Quantity = obj.Quantity;
            item.Updated = DateTime.Now;
            await _contextDAL._dbContext.SaveChangesAsync();
        }
        public async Task AddCouponToCartAsync(string sessionId, string couponCode)
        {
            ShoppingCart cart = await _contextDAL._dbContext.ShoppingCarts.FirstOrDefaultAsync(o => o.SessionId == sessionId);
            Coupon coupon = await _contextDAL._dbContext.Coupons.FirstOrDefaultAsync(o => o.Code == couponCode);
            if (coupon == null) throw new InvalidOperationException("Invalid coupon code.");
            ShoppingCartCoupon item = new ShoppingCartCoupon()
            {
                Coupon = coupon,
            };
            if (cart.Coupons == null) cart.Coupons = new List<ShoppingCartCoupon>();
            cart.Coupons.Add(item);
            await _contextDAL._dbContext.SaveChangesAsync();
        }
        public async Task RemoveCouponFromCartAsync(string sessionId, string couponCode)
        {
            // TODO: Remove this demonstration wait.
            await Task.Delay(2000);
            ShoppingCart cart = await _contextDAL._dbContext.ShoppingCarts.FirstOrDefaultAsync(o => o.SessionId == sessionId);
            ShoppingCartCoupon shoppingCartCoupon = cart.Coupons.FirstOrDefault(o => o.Coupon.Code == couponCode);
            if (shoppingCartCoupon == null) throw new InvalidOperationException("That code is not in the shopping cart.");
            cart.Coupons.Remove(shoppingCartCoupon);
            await _contextDAL._dbContext.SaveChangesAsync();
        }
    }
}
