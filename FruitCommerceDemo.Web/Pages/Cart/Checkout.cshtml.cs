using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitCommerceDemo.BLL.Models;
using FruitCommerceDemo.Web.Interfaces;

namespace FruitCommerceDemo.Web.Pages.Cart
{
    public class CheckoutModel : PageModel
    {
        private readonly IFruitCommerceApplicationService _starzApplicationService;
        private ShoppingCart _cart { get; set; }
        public CheckoutModel(IFruitCommerceApplicationService starzApplicationService)
        {
            _starzApplicationService = starzApplicationService;
        }
        public async Task OnGetAsync()
        {
            _cart = await _starzApplicationService.GetShoppingCartAsync();
        }
        public ShoppingCart Cart { get { return _cart; } }
    }
}
