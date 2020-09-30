using FruitCommerceDemo.Web.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitCommerceDemo.Web.Models
{
    public class ShoppingCartItem : IShoppingCartItem
    {
        public IProduct Product { get; set; }
        public int Quantity { get; set; }
        public decimal GetSubtotal()
        {
            return Product.Price * Quantity;
        }
        public async Task UpdateQuantityAsync(int quantity)
        {
            Quantity = quantity;
            // TODO: Remove this demonstration wait.
            await Task.Delay(300);
        }
    }
}
