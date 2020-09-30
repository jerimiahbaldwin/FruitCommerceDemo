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
    public class UpdateProductQuantityModel : PageModel
    {
        private readonly IShoppingCartService _shoppingCartService;
        public UpdateProductQuantityModel(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(int productId, int quantity)
        {
            IShoppingCart cart = await _shoppingCartService.GetCartAsync();
            IShoppingCartItem item = cart.Items.First(o => o.Product.ProductId == productId);
            if (item == null) throw new ArgumentException("Could not find that product.");
            item.Quantity = quantity;
            return RedirectToPage("/Cart/Index");

        }
    }
}
