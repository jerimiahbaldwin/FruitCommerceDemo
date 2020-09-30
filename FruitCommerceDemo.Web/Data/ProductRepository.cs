using FruitCommerceDemo.Web.Interfaces.Domain;
using FruitCommerceDemo.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitCommerceDemo.Web.Data
{
    public class ProductRepository : List<IProduct>
    {
        public ProductRepository()
        {
            // TODO: These should be pulled from DB.
            this.Add(new Product
            {
                ProductId = 1,
                Name = "Red Delicious Apples",
                Description = "That’s right: America’s favorite snacking apple is low-maintenance and ultra-productive, too. In fact, our larger Red Delicious varieties have already produced apples at our nursery.",
                Price = 5.00M,
                ImageUrl = "apples.png",
            });
            this.Add(new Product
            {
                ProductId = 2,
                Name = "Navel Oranges",
                Description = "Extra-big, beautiful, seedless, very low in acid and filled with mild, sweet flesh. These beauties are supremely simple to peel and section. Bursting with freshly picked juiciness, this is the perfect orange to serve to kids. We also like to toss sections into fruit salad.",
                Price = 10.00M,
                ImageUrl = "oranges.png",
            });
            this.Add(new Product
            {
                ProductId = 3,
                Name = "Avocados",
                Description = "",
                Price = 3.99M,
                ImageUrl = "avocados.jpg",
            });
            this.Add(new Product
            {
                ProductId = 4,
                Name = "Bananas",
                Description = "",
                Price = 3.99M,
                ImageUrl = "bananas.jpg",
            });
            this.Add(new Product
            {
                ProductId = 5,
                Name = "Blueberries",
                Description = "",
                Price = 3.99M,
                ImageUrl = "blueberries.jpg",
            });
            this.Add(new Product
            {
                ProductId = 6,
                Name = "Cherries",
                Description = "",
                Price = 3.99M,
                ImageUrl = "cherries.jpg",
            });
            this.Add(new Product
            {
                ProductId = 7,
                Name = "Grapes",
                Description = "",
                Price = 3.99M,
                ImageUrl = "grapes.jpg",
            });
            this.Add(new Product
            {
                ProductId = 8,
                Name = "Kiwis",
                Description = "",
                Price = 3.99M,
                ImageUrl = "kiwis.jpg",
            });
            this.Add(new Product
            {
                ProductId = 9,
                Name = "Lemons",
                Description = "",
                Price = 3.99M,
                ImageUrl = "lemons.jpg",
            });
            this.Add(new Product
            {
                ProductId = 10,
                Name = "Limes",
                Description = "",
                Price = 3.99M,
                ImageUrl = "limes.jpg",
            });
            this.Add(new Product
            {
                ProductId = 11,
                Name = "Manderines",
                Description = "",
                Price = 3.99M,
                ImageUrl = "manderines.jpg",
            });
            this.Add(new Product
            {
                ProductId = 12,
                Name = "Mangoes",
                Description = "",
                Price = 3.99M,
                ImageUrl = "mangoes.jpg",
            });
            this.Add(new Product
            {
                ProductId = 13,
                Name = "Pears",
                Description = "",
                Price = 3.99M,
                ImageUrl = "pears.jpg",
            });
            this.Add(new Product
            {
                ProductId = 14,
                Name = "Pineapples",
                Description = "",
                Price = 3.99M,
                ImageUrl = "pineapples.jpg",
            });
            this.Add(new Product
            {
                ProductId = 15,
                Name = "Pomegranates",
                Description = "",
                Price = 3.99M,
                ImageUrl = "pomegranates.jpg",
            });
            this.Add(new Product
            {
                ProductId = 16,
                Name = "Strawberries",
                Description = "",
                Price = 3.99M,
                ImageUrl = "strawberries.png",
            });
            this.Add(new Product
            {
                ProductId = 17,
                Name = "Watermelons",
                Description = "",
                Price = 3.99M,
                ImageUrl = "watermelons.jpg",
            });

        }
    }
}
