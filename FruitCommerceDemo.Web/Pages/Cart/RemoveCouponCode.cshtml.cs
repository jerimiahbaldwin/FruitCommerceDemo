using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitCommerceDemo.BLL.Models;
using FruitCommerceDemo.Web.Interfaces;

namespace FruitCommerceDemo.Web.Pages.Cart
{
    public class RemoveCouponCodeModel : PageModel
    {
        private readonly IFruitCommerceApplicationService _starzApplicationService;
        public RemoveCouponCodeModel(IFruitCommerceApplicationService starzApplicationService)
        {
            _starzApplicationService = starzApplicationService;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(string couponCode)
        {
            ShoppingCart cart = await _starzApplicationService.GetShoppingCartAsync();
            await cart.RemoveCouponByCodeAsync(couponCode);
            return RedirectToPage("/Cart/Index");
        }
    }
}
