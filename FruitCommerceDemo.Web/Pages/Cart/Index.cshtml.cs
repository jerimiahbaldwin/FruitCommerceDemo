using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using FruitCommerceDemo.Web.Interfaces.Domain;
using FruitCommerceDemo.Web.Interfaces.Services;

namespace FruitCommerceDemo.Web.Pages.Cart
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IShoppingCartService _shoppingCartService;
        private IShoppingCart _cart;
        public IndexModel(ILogger<IndexModel> logger, IShoppingCartService shoppingCartService)
        {
            _logger = logger;
            _shoppingCartService = shoppingCartService;
        }
        public async Task OnGetAsync(string couponError = null)
        {
            _cart = await _shoppingCartService.GetCartAsync();
            CouponError = couponError;
        }
        public IShoppingCart Cart { get { return _cart; } }
        public string CouponError { get; set; }

    }
}
