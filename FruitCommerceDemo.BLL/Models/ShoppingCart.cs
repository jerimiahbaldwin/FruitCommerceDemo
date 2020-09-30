using FruitCommerceDemo.Core.Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitCommerceDemo.BLL.Models
{
    public class ShoppingCart
    {
		private readonly ContextBLL _contextBLL;
        private IShoppingCartDTO _dto;
		private ShoppingCart() { } // hide the constructor
		public ShoppingCart(ContextBLL contextBLL, IShoppingCartDTO dto)
        {
			_contextBLL = contextBLL;
			_dto = dto;
        }
		#region Properties
		public string SessionId { get { return _dto.SessionId; } set { _dto.SessionId = value; } }
		public IEnumerable<ShoppingCartItem> Items { get { return _dto.Items.Select(o => new ShoppingCartItem(_contextBLL, o)); } }
		public IEnumerable<Coupon> Coupons { get { return _dto.Coupons.Select(o => new Coupon(o)); } }
        #endregion
        #region Methods
		private async Task Refresh()
        {
			// Refresh the underlying data.
			_dto = await _contextBLL.DAL.ShoppingCarts.GetShopppingCartBySessionIdAsync(SessionId);
		}
		public async Task<ShoppingCartItem> AddProductByIdAsync(int productId, int quantity = 1, bool refresh = true)
        {
			ShoppingCartItem shoppingCartItem = null;
			shoppingCartItem = Items.FirstOrDefault(o => o.Product.ProductId == productId);
			if (shoppingCartItem != null)
            {
				// Increase existing quantity.
				shoppingCartItem.Quantity += quantity;
				await shoppingCartItem.SaveChanges();
            } else
            {
				// Add a new shopping cart item.
				await _contextBLL.DAL.ShoppingCarts.AddProductToCartAsync(SessionId, productId, quantity);
				if (refresh) await Refresh();
			}
			return Items.FirstOrDefault(o => o.Product.ProductId == productId);
        }
		public async Task RemoveProductByIdAsync(int productId, bool refresh = true)
        {
			ShoppingCartItem item = Items.FirstOrDefault(o => o.Product.ProductId == productId);
			if (item != null)
            {
				await _contextBLL.DAL.ShoppingCarts.RemoveProductFromCartAsync(SessionId, productId);
				if (refresh) await Refresh();
			}
        }
		public async Task AddCouponByCodeAsync(string couponCode, bool refresh = true)
        {
			if (Coupons.FirstOrDefault(o => o.Code == couponCode) != null)
            {
				throw new InvalidOperationException("Coupon code is already used.");
			} else
            {
				await _contextBLL.DAL.ShoppingCarts.AddCouponToCartAsync(SessionId, couponCode);
				if (refresh) await Refresh();
			}
		}
		public async Task RemoveCouponByCodeAsync(string couponCode, bool refresh = true)
        {
			if (Coupons.FirstOrDefault(o => o.Code == couponCode) == null)
			{
				throw new InvalidOperationException("That coupon is not in the cart.");
			} else
            {
				await _contextBLL.DAL.ShoppingCarts.RemoveCouponFromCartAsync(SessionId, couponCode);
				if (refresh) await Refresh();
            }
		}
		public decimal GetSubtotal()
		{
			decimal subtotal = 0M;
			foreach (ShoppingCartItem item in Items)
			{
				subtotal += item.Product.Price * item.Quantity;
			}
			return subtotal;
		}
		public decimal GetDiscountTotal()
		{
			decimal discountTotal = 0M;
			foreach (Coupon coupon in Coupons)
			{
				foreach (ShoppingCartItem item in Items)
				{
					if (coupon.AppliesToProductIds.ToList().Contains(item.Product.ProductId))
                    {
						discountTotal += item.Product.Price * coupon.DiscountPercent * item.Quantity;
					}
				}
			}
			return discountTotal;
		}
		public decimal GetTotal()
		{
			return GetSubtotal() - GetDiscountTotal();
		}
        #endregion
    }
}
