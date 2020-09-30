using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitCommerceDemo.BLL.Models;
using FruitCommerceDemo.Web.Interfaces;

namespace FruitCommerceDemo.Web.Pages.Cart
{
    public class IndexModel : PageModel
    {
        private readonly IFruitCommerceApplicationService _starzApplicationService;
        private ShoppingCart _cart;
        public IndexModel(IFruitCommerceApplicationService starzApplicationService)
        {
            _starzApplicationService = starzApplicationService;
        }
        public async Task OnGetAsync(string couponError = null)
        {
            _cart = await _starzApplicationService.GetShoppingCartAsync();
            CouponError = couponError;
        }
        public ShoppingCart Cart { get { return _cart; } }
        public string CouponError { get; set; }

    }
}
