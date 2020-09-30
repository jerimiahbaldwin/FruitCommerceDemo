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
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;
        private IEnumerable<IProduct> _products = new List<IProduct>();
        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }
        public async Task OnGetAsync()
        {
            _products = await _productService.GetAllAsync();
        }
        public IEnumerable<IProduct> Products { get { return _products; } }
    }
}
