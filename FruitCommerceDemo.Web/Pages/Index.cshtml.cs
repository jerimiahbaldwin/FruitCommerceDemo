using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitCommerceDemo.BLL.Models;
using FruitCommerceDemo.Web.Interfaces;

namespace FruitCommerceDemo.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IFruitCommerceApplicationService _starzApplicationService;
        public IndexModel(IFruitCommerceApplicationService starzApplicationService)
        {
            _starzApplicationService = starzApplicationService;
        }
        public async Task OnGetAsync()
        {
            Products = await _starzApplicationService.ContextBLL.Products.GetAllAsync();
            ProductsTopTrending = await _starzApplicationService.ContextBLL.Products.GetTopTrendingAsync();
        }
        public IEnumerable<Product> Products { get; private set; } = new List<Product>();
        public IEnumerable<Product> ProductsTopTrending { get; private set; } = new List<Product>();

    }
}
