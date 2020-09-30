using Xunit;
using Microsoft.EntityFrameworkCore;
using System;
using FruitCommerceDemo.EF.Entities;

namespace FruitCommerceDemo.EF.Test
{
    public class SeedData : IDisposable
    {
        private ApplicationDbContext _ctx;
        public SeedData()
        {
            _ctx = new ApplicationDbContext();
        }

        [Fact]
        public async void MultipleProducts()
        {
            Assert.True(await _ctx.Products.CountAsync() > 10);
        }
        [Fact]
        public async void KeyProducts()
        {
            Product apple = await _ctx.Products.FirstOrDefaultAsync(o => o.ProductId == 1);
            Assert.Equal("Red Delicious Apples", apple.Name);
            Assert.Equal(5.00M, apple.Price);
            Product orange = await _ctx.Products.FirstOrDefaultAsync(o => o.ProductId == 2);
            Assert.Equal("Navel Oranges", orange.Name);
            Assert.Equal(10.00M, orange.Price);
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
