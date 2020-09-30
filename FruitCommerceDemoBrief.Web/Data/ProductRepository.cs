using FruitCommerceDemoBrief.Web.Interfaces.Domain;
using FruitCommerceDemoBrief.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitCommerceDemoBrief.Web.Data
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
                ImageUrl = "https://store.jacksfoodland.com/media/catalog/product/cache/ecd051e9670bd57df35c8f0b122d8aea/3/3/3338308041.png",
            });
            this.Add(new Product
            {
                ProductId = 2,
                Name = "Navel Oranges",
                Description = "Extra-big, beautiful, seedless, very low in acid and filled with mild, sweet flesh. These beauties are supremely simple to peel and section. Bursting with freshly picked juiciness, this is the perfect orange to serve to kids. We also like to toss sections into fruit salad.",
                Price = 10.00M,
                ImageUrl = "https://cdn.pixabay.com/photo/2020/04/04/01/33/navel-5000527_1280.png",
            });

        }
    }
}
