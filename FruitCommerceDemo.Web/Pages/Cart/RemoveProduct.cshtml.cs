using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitCommerceDemo.BLL.Models;
using FruitCommerceDemo.Web.Interfaces;

namespace FruitCommerceDemo.Web.Pages.Cart
{
    public class RemoveProductModel : PageModel
    {
        private readonly IFruitCommerceApplicationService _starzApplicationService;
        public RemoveProductModel(IFruitCommerceApplicationService starzApplicationService)
        {
            _starzApplicationService = starzApplicationService;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(int productId)
        {
            ShoppingCart cart = await _starzApplicationService.GetShoppingCartAsync();
            await cart.RemoveProductByIdAsync(productId);
            return RedirectToPage("/Cart/Index");
        }
    }
}
