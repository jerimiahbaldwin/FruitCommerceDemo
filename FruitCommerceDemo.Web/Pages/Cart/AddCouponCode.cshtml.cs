using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitCommerceDemo.BLL.Models;
using FruitCommerceDemo.Web.Interfaces;

namespace FruitCommerceDemo.Web.Pages.Cart
{
    public class AddCouponCodeModel : PageModel
    {
        private readonly IFruitCommerceApplicationService _starzApplicationService;
        public AddCouponCodeModel(IFruitCommerceApplicationService starzApplicationService)
        {
            _starzApplicationService = starzApplicationService;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(string couponCode)
        {
            ShoppingCart cart = await _starzApplicationService.GetShoppingCartAsync();
            try
            {
                await cart.AddCouponByCodeAsync(couponCode);
                return RedirectToPage("/Cart/Index");
            }
            catch (InvalidOperationException e)
            {
                return RedirectToPage("/Cart/Index", new { couponError = e.Message});
            }
        }
    }
}
