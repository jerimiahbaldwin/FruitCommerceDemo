using FruitCommerceDemo.BLL.Services;
using FruitCommerceDemo.DAL;
using FruitCommerceDemo.DAL.Contexts;

namespace FruitCommerceDemo.BLL
{
    public class ContextBLL
    {
        public ContextBLL()
        {
            Products = new ProductService(this);
            Coupons = new CouponService(this);
            ShoppingCarts = new ShoppingCartService(this);
        }
        internal IContextDAL DAL { get; set; } = new ContextDAL();
        public ProductService Products { get; set; }
        public CouponService Coupons { get; set; }
        public ShoppingCartService ShoppingCarts { get; set; }
    }
}
