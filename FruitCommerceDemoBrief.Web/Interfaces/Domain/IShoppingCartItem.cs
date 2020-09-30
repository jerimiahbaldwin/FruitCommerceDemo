using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitCommerceDemoBrief.Web.Interfaces.Domain
{
    public interface IShoppingCartItem
    {
        IProduct Product { get; set; }
        int Quantity { get; set; }
        decimal GetSubtotal();
    }
}
