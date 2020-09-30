using FruitCommerceDemoBrief.Web.Interfaces.Services;
using FruitCommerceDemoBrief.Web.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FruitCommerceDemoBrief.Web.Data;

namespace FruitCommerceDemoBrief.Web.Services
{
    public class ProductService : IProductService
    {
        private List<IProduct> _products;
        public ProductService()
        {
            _products = new ProductRepository();
        }
        public async Task<IProduct> GetAsync(int productId)
        {
            // TODO: Remove this demonstration wait.
            await Task.Delay(100);
            return _products.Find(p => p.ProductId == productId);
        }
        public async Task<IEnumerable<IProduct>> GetAllAsync()
        {
            // TODO: Remove this demonstration wait.
            await Task.Delay(100);
            return _products;
        }
    }
}
