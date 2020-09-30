using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FruitCommerceDemo.Core.Interfaces.DTO;
using FruitCommerceDemo.BLL.Models;
using System.Linq;

namespace FruitCommerceDemo.BLL.Services
{
    public class ProductService
    {
        private readonly ContextBLL _contextBLL;
        private ProductService() { } // hide constructor
        public ProductService(ContextBLL contextBLL)
        {
            _contextBLL = contextBLL;
        }
        public async Task<Product> GetAsync(int productId)
        {
            return new Product(await _contextBLL.DAL.Products.GetProductByIdAsync(productId));
        }
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return (await _contextBLL.DAL.Products.GetAllProductsAsync()).Select(o => new Product(o));
        }
        public async Task<IEnumerable<Product>> GetTopTrendingAsync()
        {
            return (await _contextBLL.DAL.Products.GetTrendingProductsAsync()).Select(o => new Product(o));
        }
        public async Task<IEnumerable<Product>> GetRelatedProductsAsync(int productId)
        {
            return (await _contextBLL.DAL.Products.GetRelatedProductsAsync(productId)).Select(o => new Product(o));
        }
    }
}
