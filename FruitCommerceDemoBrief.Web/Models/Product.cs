using FruitCommerceDemoBrief.Web.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitCommerceDemoBrief.Web.Models
{
    public class Product : IProduct
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
