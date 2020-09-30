using System.Threading.Tasks;
using FruitCommerceDemo.Core.Interfaces.DTO;

namespace FruitCommerceDemo.Core.Interfaces.DataProviders
{
    public interface ICouponDataProvider
    {
        Task<ICouponDTO> GetCouponByCodeAsync(string couponCode);
    }
}
