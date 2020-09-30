using FruitCommerceDemo.Core.Interfaces.DTO;
using FruitCommerceDemo.EF.Entities;

namespace FruitCommerceDemo.DAL.DTO
{
    public class ShoppingCartItemDTO : IShoppingCartItemDTO
    {
        public ShoppingCartItemDTO(ShoppingCartItem item)
        {
            ShoppingCartId = item.ShoppingCartId;
            Product = new ProductDTO(item.Product);
            Quantity = item.Quantity;
        }
        public int ShoppingCartId { get; set; }
        public IProductDTO Product { get; set; }
        public int Quantity { get; set; }
    }
}
