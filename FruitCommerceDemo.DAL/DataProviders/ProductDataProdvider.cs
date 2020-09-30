using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FruitCommerceDemo.Core.Interfaces.DataProviders;
using FruitCommerceDemo.Core.Interfaces.DTO;
using FruitCommerceDemo.EF.Entities;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using FruitCommerceDemo.DAL.DTO;

namespace FruitCommerceDemo.DAL.DataProviders
{
    public class ProductDataProvider : IProductDataProvider
    {
        private readonly ContextDAL _contextDAL;
        private ProductDataProvider() { }
        public ProductDataProvider(ContextDAL contextDAL)
        {
            _contextDAL = contextDAL;
        }
        public async Task<IProductDTO> GetProductByIdAsync(int productId)
        {
            // TODO: Remove this demonstration wait.
            await Task.Delay(100);
            return new ProductDTO(await _contextDAL._dbContext.Products.FindAsync(productId));
        }

        public async Task<IEnumerable<IProductDTO>> GetAllProductsAsync()
        {
            // TODO: Remove this demonstration wait.
            await Task.Delay(100);
            return (await _contextDAL._dbContext.Products.ToListAsync()).Select(o => new ProductDTO(o));
        }

        public async Task<IEnumerable<IProductDTO>> GetTrendingProductsAsync()
        {
            List<int> trendingProductIds = new List<int> { 1, 2, 4, 6, 8, 10, 11, 12 };
            IEnumerable<Product> products = await _contextDAL._dbContext.Products.Where(o => trendingProductIds.Contains(o.ProductId)).ToListAsync();
            return products.Select(o => new ProductDTO(o));
        }

        public async Task<IEnumerable<IProductDTO>> GetRelatedProductsAsync(int productId)
        {
            List<int> relatedProductIds = new List<int> { 2, 4, 6, 8, 10, 11, 12, 13 };
            // Remove the reference product if it is in the list.
            if (relatedProductIds.Contains(productId)) relatedProductIds.Remove(productId);
            IEnumerable<Product> products = await _contextDAL._dbContext.Products.Where(o => relatedProductIds.Contains(o.ProductId)).ToListAsync();
            return products.Select(o => new ProductDTO(o));
        }
    }
}
