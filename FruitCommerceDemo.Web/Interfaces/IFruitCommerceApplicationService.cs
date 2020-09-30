using System.Threading.Tasks;
using FruitCommerceDemo.BLL;
using FruitCommerceDemo.BLL.Models;

namespace FruitCommerceDemo.Web.Interfaces
{
    public interface IFruitCommerceApplicationService
    {
        public ContextBLL ContextBLL { get; set; }
        Task<ShoppingCart> GetShoppingCartAsync();
    }
}
