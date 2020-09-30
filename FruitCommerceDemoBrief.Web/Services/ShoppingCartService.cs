using Microsoft.AspNetCore.Http;
using FruitCommerceDemoBrief.Web.Interfaces.Services;
using FruitCommerceDemoBrief.Web.Interfaces.Domain;
using FruitCommerceDemoBrief.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitCommerceDemoBrief.Web.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private static readonly Dictionary<string, IShoppingCart> _carts = new Dictionary<string, IShoppingCart>();
        private readonly IProductService _productService;
        private readonly ICouponService _couponService;
        private IHttpContextAccessor _httpContextAccessor;
        public ShoppingCartService(IProductService productService, ICouponService couponService, IHttpContextAccessor httpContextAccessor)
        {
            _productService = productService;
            _couponService = couponService;
            _httpContextAccessor = httpContextAccessor;
        }   
        public async Task<IShoppingCart> GetCartAsync()
        {
            if (!_carts.Keys.Contains(_httpContextAccessor.HttpContext.Session.Id))
            {
                _carts[_httpContextAccessor.HttpContext.Session.Id] = new ShoppingCart(_productService, _couponService);
            }
            IShoppingCart cart = _carts[_httpContextAccessor.HttpContext.Session.Id];
            // TODO: Remove this demonstration wait.
            await Task.Delay(100);
            return cart;
        }
    }
}
