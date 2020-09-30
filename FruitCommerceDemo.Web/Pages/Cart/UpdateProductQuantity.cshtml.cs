using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitCommerceDemo.BLL.Models;
using FruitCommerceDemo.Web.Interfaces;

namespace FruitCommerceDemo.Web.Pages.Cart
{
    public class UpdateProductQuantityModel : PageModel
    {
        private readonly IFruitCommerceApplicationService _starzApplicationService;
        public UpdateProductQuantityModel(IFruitCommerceApplicationService starzApplicationService)
        {
            _starzApplicationService = starzApplicationService;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(int productId, int quantity)
        {
            ShoppingCart cart = await _starzApplicationService.GetShoppingCartAsync();
            ShoppingCartItem item = cart.Items.FirstOrDefault(o => o.Product.ProductId == productId);
            if (item == null) throw new InvalidOperationException("Could not find that product.");
            item.Quantity = quantity;
            await item.SaveChanges();
            return RedirectToPage("/Cart/Index");

        }
    }
}
