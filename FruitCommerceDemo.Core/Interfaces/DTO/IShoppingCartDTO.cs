using System.Collections.Generic;

namespace FruitCommerceDemo.Core.Interfaces.DTO
{
    public interface IShoppingCartDTO
    {
        int ShoppingCartId { get; set; }
        string SessionId { get; set; }
        IEnumerable<IShoppingCartItemDTO> Items { get; set; }
        IEnumerable<ICouponDTO> Coupons { get; set; }
    }
}
