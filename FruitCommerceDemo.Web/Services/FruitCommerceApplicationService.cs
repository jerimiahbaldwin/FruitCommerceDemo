using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using FruitCommerceDemo.BLL;
using FruitCommerceDemo.BLL.Models;
using FruitCommerceDemo.Web.Interfaces;

namespace FruitCommerceDemo.Web.Services
{
    public class FruitCommerceApplicationService : IFruitCommerceApplicationService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private FruitCommerceApplicationService() { }
        public FruitCommerceApplicationService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public ContextBLL ContextBLL { get; set; } = new ContextBLL();
        public async Task<ShoppingCart> GetShoppingCartAsync()
        {
            string sessionId = _httpContextAccessor.HttpContext.Session.Id;
            return await ContextBLL.ShoppingCarts.GetShoppingCartAsync(sessionId);
        }
    }
}
