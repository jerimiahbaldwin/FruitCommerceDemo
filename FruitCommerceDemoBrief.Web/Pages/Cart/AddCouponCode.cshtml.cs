using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitCommerceDemoBrief.Web.Interfaces.Domain;
using FruitCommerceDemoBrief.Web.Interfaces.Services;

namespace FruitCommerceDemoBrief.Web.Pages.Cart
{
    public class AddCouponCodeModel : PageModel
    {
        private readonly IShoppingCartService _shoppingCartService;
        public AddCouponCodeModel(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(string couponCode)
        {
            IShoppingCart cart = await _shoppingCartService.GetCartAsync();
            try
            {
                await cart.AddCouponByCodeAsync(couponCode);
                return RedirectToPage("/Cart/Index");
            }
            catch (ArgumentException e)
            {
                return RedirectToPage("/Cart/Index", new { couponError = e.Message });
            }
        }
    }
}
