using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Connections.Features;
using FruitCommerceDemo.Web.Interfaces.Domain;

namespace FruitCommerceDemo.Web.Interfaces.Services
{
    public interface IShoppingCartService
    {
        Task<IShoppingCart> GetCartAsync();
    }
}
