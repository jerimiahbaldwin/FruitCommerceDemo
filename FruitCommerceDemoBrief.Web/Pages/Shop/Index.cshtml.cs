using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitCommerceDemoBrief.Web.Interfaces.Domain;
using FruitCommerceDemoBrief.Web.Interfaces.Services;

namespace FruitCommerceDemoBrief.Web.Pages.Shop
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
