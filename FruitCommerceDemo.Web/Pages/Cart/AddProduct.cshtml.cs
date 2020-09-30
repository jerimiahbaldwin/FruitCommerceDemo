using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitCommerceDemo.Web.Interfaces.Domain;
using FruitCommerceDemo.Web.Interfaces.Services;

namespace FruitCommerceDemo.Web.Pages.Cart
{
    public class AddProductModel : PageModel
    {
        private readonly IShoppingCartService _shoppingCartService;
        public AddProductModel(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(int productId)
        {
            IShoppingCart cart = await _shoppingCartService.GetCartAsync();
            await cart.AddProductByIdAsync(productId);
            return RedirectToPage("/Cart/Index");
        }
    }
}
