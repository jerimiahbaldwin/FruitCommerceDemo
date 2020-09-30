using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using FruitCommerceDemo.Web.Interfaces.Domain;
using FruitCommerceDemo.Web.Interfaces.Services;

namespace FruitCommerceDemo.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;
        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }
        public async Task OnGetAsync()
        {
            Products = await _productService.GetAllAsync();
            ProductsTopTrending = new List<IProduct> {
                await _productService.GetAsync(2),
                await _productService.GetAsync(4),
                await _productService.GetAsync(6),
                await _productService.GetAsync(8),
                await _productService.GetAsync(10),
                await _productService.GetAsync(11),
                await _productService.GetAsync(12),
                await _productService.GetAsync(13),
            };
        }
        public IEnumerable<IProduct> Products { get; private set; } = new List<IProduct>();
        public IEnumerable<IProduct> ProductsTopTrending { get; private set; } = new List<IProduct>();

    }
}
