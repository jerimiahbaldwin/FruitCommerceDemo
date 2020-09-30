using FruitCommerceDemo.Core.Interfaces.DataProviders;
using FruitCommerceDemo.DAL.Contexts;
using FruitCommerceDemo.DAL.DataProviders;
using FruitCommerceDemo.EF;

namespace FruitCommerceDemo.DAL
{
    public class ContextDAL : IContextDAL
    {
        internal ApplicationDbContext _dbContext;
        public ContextDAL()
        {
            Products = new ProductDataProvider(this);
            Coupons = new CouponDataProvider(this);
            ShoppingCarts = new ShoppingCartDataProvider(this);
            _dbContext = new ApplicationDbContext();
        }
        public IProductDataProvider Products { get; set; }
        public ICouponDataProvider Coupons { get; set; }
        public IShoppingCartDataProvider ShoppingCarts { get; set; }
    }
}
