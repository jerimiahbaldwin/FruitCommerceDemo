using FruitCommerceDemo.Core.Interfaces.DTO;
using FruitCommerceDemo.EF.Entities;

namespace FruitCommerceDemo.DAL.DTO
{
    public class ProductDTO : IProductDTO
    {
        public ProductDTO(Product product)
        {
            ProductId = product.ProductId;
            Name = product.Name;
            Description = product.Description;
            ImageUrl = product.ImageUrl;
            Price = product.Price;
        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
