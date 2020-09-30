using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitCommerceDemo.BLL.Models;
using FruitCommerceDemo.Web.Interfaces;

namespace FruitCommerceDemo.Web.Pages.Shop
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
        }
        public IEnumerable<Product> Products { get; private set; } = new List<Product>();
    }
}
