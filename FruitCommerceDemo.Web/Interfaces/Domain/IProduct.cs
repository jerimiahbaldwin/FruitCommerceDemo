using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitCommerceDemo.Web.Interfaces.Domain
{
    public interface IProduct
    {
        int ProductId { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string ImageUrl { get; set; }
        decimal Price { get; set; }
    }
}
