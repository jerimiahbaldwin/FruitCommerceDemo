using System.Threading.Tasks;
using FruitCommerceDemo.Core.Interfaces.DTO;
using FruitCommerceDemo.BLL.Models;

namespace FruitCommerceDemo.BLL.Services
{
    public class ShoppingCartService
    {
        private readonly ContextBLL _contextBLL;
        private ShoppingCartService() { } // hide constructor
        public ShoppingCartService(ContextBLL contextBLL)
        {
            _contextBLL = contextBLL;
        }   
        public async Task<ShoppingCart> GetShoppingCartAsync(string sessionId)
        {
            IShoppingCartDTO dto =  await _contextBLL.DAL.ShoppingCarts.GetShopppingCartBySessionIdAsync(sessionId);
            return new ShoppingCart(_contextBLL, dto);
        }
        public async Task<ShoppingCartItem> AddProductToCartAsync(ShoppingCart shoppingCart, Product product, int quantity)
        {
            IShoppingCartItemDTO item = await _contextBLL.DAL.ShoppingCarts.AddProductToCartAsync(shoppingCart.SessionId, product.ProductId, quantity);
            return new ShoppingCartItem(_contextBLL, item);
        }
    }
}
