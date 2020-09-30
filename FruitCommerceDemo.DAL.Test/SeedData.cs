using FruitCommerceDemo.Core.Interfaces.DTO;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FruitCommerceDemo.DAL.Test
{
    public class SeedData
    {
        private ContextDAL _ctx;
        public SeedData()
        {
            _ctx = new ContextDAL();
        }
        [Fact]
        public async void MultipleProducts()
        {
            IEnumerable<IProductDTO> products = await _ctx.Products.GetAllProductsAsync();
            Assert.True(products.Count() > 10);
        }
        [Fact]
        public async void KeyProducts()
        {
            IProductDTO apple = await _ctx.Products.GetProductByIdAsync(1);
            Assert.Equal("Red Delicious Apples", apple.Name);
            Assert.Equal(5.00M, apple.Price);
            IProductDTO orange = await _ctx.Products.GetProductByIdAsync(2);
            Assert.Equal("Navel Oranges", orange.Name);
            Assert.Equal(10.00M, orange.Price);
        }
    }
}
