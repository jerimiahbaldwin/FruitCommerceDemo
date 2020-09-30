using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitCommerceDemo.BLL.Models;
using FruitCommerceDemo.Web.Interfaces;

namespace FruitCommerceDemo.Web.Pages.Shop
{
    public class ProductDetailModel : PageModel
    {
        private readonly IFruitCommerceApplicationService _starzApplicationService;
        public ProductDetailModel(IFruitCommerceApplicationService starzApplicationService)
        {
            _starzApplicationService = starzApplicationService;
        }
        public async Task OnGetAsync(int productId)
        {
            Product = await _starzApplicationService.ContextBLL.Products.GetAsync(productId);
            RelatedProducts = await _starzApplicationService.ContextBLL.Products.GetRelatedProductsAsync(productId);
        }
        public Product Product { get; set; }
        public IEnumerable<Product> RelatedProducts { get; private set; } = new List<Product>();
    }
}
