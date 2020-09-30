using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitCommerceDemo.Web.Interfaces.Domain;
using FruitCommerceDemo.Web.Interfaces.Services;

namespace FruitCommerceDemo.Web.Pages.Cart
{
    public class RemoveCouponCodeModel : PageModel
    {
        private readonly IShoppingCartService _shoppingCartService;
        public RemoveCouponCodeModel(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(string couponCode)
        {
            IShoppingCart cart = await _shoppingCartService.GetCartAsync();
            await cart.RemoveCouponByCodeAsync(couponCode);
            return RedirectToPage("/Cart/Index");
        }
    }
}
