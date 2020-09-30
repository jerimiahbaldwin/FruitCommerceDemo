using System.Collections.Generic;
using System.Threading.Tasks;
using FruitCommerceDemo.Core.Interfaces.DTO;

namespace FruitCommerceDemo.Core.Interfaces.DataProviders
{
    public interface IProductDataProvider
    {
        Task<IProductDTO> GetProductByIdAsync(int productId);
        Task<IEnumerable<IProductDTO>> GetAllProductsAsync();
        Task<IEnumerable<IProductDTO>> GetTrendingProductsAsync();
        Task<IEnumerable<IProductDTO>> GetRelatedProductsAsync(int productId);
    }
}
