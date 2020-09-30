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
    public class RemoveProductModel : PageModel
    {
        private readonly IShoppingCartService _shoppingCartService;
        public RemoveProductModel(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(int productId)
        {
            IShoppingCart cart = await _shoppingCartService.GetCartAsync();
            await cart.RemoveProductByIdAsync(productId);
            return RedirectToPage("/Cart/Index");
        }
    }
}
