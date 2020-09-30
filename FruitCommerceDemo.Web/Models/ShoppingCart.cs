using FruitCommerceDemo.Web.Interfaces.Domain;
using FruitCommerceDemo.Web.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FruitCommerceDemo.Web.Models
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly List<IShoppingCartItem> _items = new List<IShoppingCartItem>();
        private readonly List<ICoupon> _coupons = new List<ICoupon>();
		private readonly ICouponService _couponService;
		private readonly IProductService _productService;
		public ShoppingCart(IProductService productService, ICouponService couponService)
        {
			_couponService = couponService;
			_productService = productService;
        }
        #region Properties
        public IEnumerable<IShoppingCartItem> Items { get {  return _items; } }
		public IEnumerable<ICoupon> Coupons { get { return _coupons; } }
        #endregion
        #region Methods
        public async Task<IShoppingCartItem> AddProductAsync(IProduct product, int quantity = 1)
        {
			IShoppingCartItem shoppingCartItem = null;
			shoppingCartItem = _items.Find(o => o.Product.ProductId == product.ProductId);

			if (shoppingCartItem != null)
            {
				// Increase existing quantity.
				shoppingCartItem.Quantity += quantity;
            } else
            {
				// Add a new shopping cart item.
				shoppingCartItem = new ShoppingCartItem
				{
					Product = product,
					Quantity = quantity,
				};
				_items.Add(shoppingCartItem);
			}
			// TODO: Remove this demonstration wait.
			await Task.Delay(2000);
			return shoppingCartItem;
        }
		public async Task<IShoppingCartItem> AddProductByIdAsync(int productId, int quantity = 1)
		{
			IProduct product = await _productService.GetAsync(productId);
			return await AddProductAsync(product, quantity);
		}
		public async Task RemoveProductByIdAsync(int productId)
        {
			IShoppingCartItem item = _items.Find(o => o.Product.ProductId == productId);
			if (item != null)
            {
				_items.Remove(item);
			}
			// TODO: Remove this demonstration wait.
			await Task.Delay(2000);
        }
        public async Task AddCouponAsync(ICoupon coupon)
        {
            _coupons.Add(coupon);
			// TODO: Remove this demonstration wait.
			await Task.Delay(2000);
        }
		public async Task AddCouponByCodeAsync(string couponCode)
        {
			if (_coupons.Find(o => o.Code == couponCode) != null)
            {
				throw new ArgumentException("Coupon code is already used.");
			} else
            {
				ICoupon coupon = await _couponService.GetByCodeAsync(couponCode);
				if (coupon == null) throw new ArgumentException("Invalid coupon code.");
				await AddCouponAsync(coupon);
			}
		}
		public async Task RemoveCouponAsync(ICoupon coupon)
        {
			_coupons.Remove(coupon);
			// TODO: Remove this demonstration wait.
			await Task.Delay(300);
		}
		public async Task RemoveCouponByCodeAsync(string couponCode)
        {
			ICoupon coupon = _coupons.Find(o => o.Code == couponCode);
			if (coupon != null) _coupons.Remove(coupon);
			// TODO: Remove this demonstration wait.
			await Task.Delay(2000);
		}
		public async Task SetQuantityByProductIdAsync(int productId, int quantity)
		{
			IShoppingCartItem item = _items.Find(o => o.Product.ProductId == productId);
			if (item != null)
			{
				item.Quantity = quantity;
			}
			// TODO: Remove this demonstration wait.
			await Task.Delay(500);
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
			foreach (ICoupon coupon in Coupons)
			{
				foreach (IShoppingCartItem item in Items)
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
