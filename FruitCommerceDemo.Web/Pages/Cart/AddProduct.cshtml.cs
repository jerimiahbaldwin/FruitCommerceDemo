using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitCommerceDemo.BLL.Models;
using FruitCommerceDemo.Web.Interfaces;

namespace FruitCommerceDemo.Web.Pages.Cart
{
    public class AddProductModel : PageModel
    {
        private readonly IFruitCommerceApplicationService _starzApplicationService;
        public AddProductModel(IFruitCommerceApplicationService starzApplicationService)
        {
            _starzApplicationService = starzApplicationService;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(int productId, int quantity = 1)
        {
            ShoppingCart cart = await _starzApplicationService.GetShoppingCartAsync();
            await cart.AddProductByIdAsync(productId, quantity);
            return RedirectToPage("/Cart/Index");
        }
    }
}
