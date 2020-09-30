using FruitCommerceDemo.Core.Interfaces.DTO;

namespace FruitCommerceDemo.BLL.Models
{
    public class Product
    {
        private readonly IProductDTO _dto;
        private Product() { } // hide the constructor
        public Product(IProductDTO dto)
        {
            _dto = dto;
        }
        public int ProductId { get { return _dto.ProductId; } }
        public string Name { get { return _dto.Name; } set { _dto.Name = value; } }
        public string Description { get { return _dto.Description; } set { _dto.Description = value; } }
        public string ImageUrl { get { return _dto.ImageUrl; } set { _dto.ImageUrl = value; } }
        public decimal Price { get { return _dto.Price; } set { _dto.Price = value; } }
    }
}
