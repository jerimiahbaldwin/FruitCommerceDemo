using FruitCommerceDemo.Core.Interfaces.DataProviders;

namespace FruitCommerceDemo.DAL.Contexts
{
    public interface IContextDAL
    {
        ICouponDataProvider Coupons { get; set; }
        IProductDataProvider Products { get; set; }
        IShoppingCartDataProvider ShoppingCarts { get; set; }
    }
}
