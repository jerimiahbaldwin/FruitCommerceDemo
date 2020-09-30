using System.Threading.Tasks;
using FruitCommerceDemo.Core.Interfaces.DTO;

namespace FruitCommerceDemo.Core.Interfaces.DataProviders
{
    public interface IShoppingCartDataProvider
    {
        Task<IShoppingCartDTO> GetShopppingCartBySessionIdAsync(string sessionId);
        Task<IShoppingCartItemDTO> AddProductToCartAsync(string sessionId, int productId, int quantity);
        Task RemoveProductFromCartAsync(string sessionId, int productId);
        Task UpdateCartItemAsync(IShoppingCartItemDTO obj);
        Task AddCouponToCartAsync(string sessionId, string couponCode);
        Task RemoveCouponFromCartAsync(string sessionId, string couponCode);
    }
}
