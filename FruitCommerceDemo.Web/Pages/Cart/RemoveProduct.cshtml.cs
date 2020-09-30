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
