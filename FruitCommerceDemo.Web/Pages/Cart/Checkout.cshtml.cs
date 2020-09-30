using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using FruitCommerceDemo.Web.Interfaces.Domain;
using FruitCommerceDemo.Web.Interfaces.Services;

namespace FruitCommerceDemo.Web.Pages.Cart
{
    public class CheckoutModel : PageModel
    {
        private readonly ILogger<CheckoutModel> _logger;
        private readonly IShoppingCartService _shoppingCartService;
        private IShoppingCart _cart;
        public CheckoutModel(ILogger<CheckoutModel> logger, IShoppingCartService shoppingCartService)
        {
            _logger = logger;
            _shoppingCartService = shoppingCartService;
        }
        public async Task OnGetAsync()
        {
            _cart = await _shoppingCartService.GetCartAsync();
        }
        public IShoppingCart Cart { get { return _cart; } }
    }
}
