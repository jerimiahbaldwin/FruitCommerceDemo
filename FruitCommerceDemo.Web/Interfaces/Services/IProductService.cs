using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FruitCommerceDemo.Web.Interfaces.Domain;

namespace FruitCommerceDemo.Web.Interfaces.Services
{
    public interface IProductService
    {
        Task<IEnumerable<IProduct>> GetAllAsync();
        Task<IProduct> GetAsync(int productId);
    }
}
