using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitCommerceDemo.Web.Interfaces.Domain;
using FruitCommerceDemo.Web.Interfaces.Services;

namespace FruitCommerceDemo.Web.Pages.Shop
{
    public class ProductDetailModel : PageModel
    {

        private readonly IProductService _productService;

        public ProductDetailModel(IProductService productService)
        {
            _productService = productService;
        }

        public async Task OnGetAsync(int productId)
        {
            Product = await _productService.GetAsync(productId);
            RelatedProducts = new List<IProduct> 
            { 
                await _productService.GetAsync(11),
                await _productService.GetAsync(12),
                await _productService.GetAsync(13),
                await _productService.GetAsync(14),
            };
        }
        public IProduct Product { get; set; }
        public IEnumerable<IProduct> RelatedProducts { get; private set; } = new List<IProduct>();
    }
}
