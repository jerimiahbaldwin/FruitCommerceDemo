using FruitCommerceDemo.Core.Interfaces.DTO;
using System.Threading.Tasks;

namespace FruitCommerceDemo.BLL.Models
{
    public class ShoppingCartItem
    {
        private readonly ContextBLL _contextBLL;
        private readonly IShoppingCartItemDTO _dto;
        private ShoppingCartItem() { } // hide the constructor
        public ShoppingCartItem(ContextBLL contextBLL, IShoppingCartItemDTO dto)
        {
            _contextBLL = contextBLL;
            _dto = dto;
        }
        public Product Product { get { return new Product(_dto.Product); } }
        public int Quantity { get { return _dto.Quantity; } set { _dto.Quantity = value; } }
        public decimal GetSubtotal()
        {
            return Product.Price * Quantity;
        }
        public async Task SaveChanges()
        {
            await _contextBLL.DAL.ShoppingCarts.UpdateCartItemAsync(_dto);
        }
    }
}
