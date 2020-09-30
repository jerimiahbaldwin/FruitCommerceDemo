using Microsoft.EntityFrameworkCore;
using FruitCommerceDemo.EF.Entities;

namespace FruitCommerceDemo.EF
{
    public class ApplicationDbContext : DbContext
    {
        private static ApplicationDbContext _applicationDbContext;
        public ApplicationDbContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FruitCommerceDemo.Store;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(options);
        }
        public static ApplicationDbContext GetSingleton()
        {
            if (_applicationDbContext == null)
            {
                _applicationDbContext = new ApplicationDbContext();
            }
            return _applicationDbContext;
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            /*
             * PRODUCT SEED DATA
             */

            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Red Delicious Apples",
                Description = "That’s right: America’s favorite snacking apple is low-maintenance and ultra-productive, too. In fact, our larger Red Delicious varieties have already produced apples at our nursery.",
                Price = 5.00M,
                ImageUrl = "apples.png",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Navel Oranges",
                Description = "Extra-big, beautiful, seedless, very low in acid and filled with mild, sweet flesh. These beauties are supremely simple to peel and section. Bursting with freshly picked juiciness, this is the perfect orange to serve to kids. We also like to toss sections into fruit salad.",
                Price = 10.00M,
                ImageUrl = "oranges.png",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Avocados",
                Description = "",
                Price = 3.99M,
                ImageUrl = "avocados.jpg",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Bananas",
                Description = "",
                Price = 3.99M,
                ImageUrl = "bananas.jpg",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Blueberries",
                Description = "",
                Price = 3.99M,
                ImageUrl = "blueberries.jpg",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Cherries",
                Description = "",
                Price = 3.99M,
                ImageUrl = "cherries.jpg",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Grapes",
                Description = "",
                Price = 3.99M,
                ImageUrl = "grapes.jpg",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Kiwis",
                Description = "",
                Price = 3.99M,
                ImageUrl = "kiwis.jpg",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Lemons",
                Description = "",
                Price = 3.99M,
                ImageUrl = "lemons.jpg",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Limes",
                Description = "",
                Price = 3.99M,
                ImageUrl = "limes.jpg",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Manderines",
                Description = "",
                Price = 3.99M,
                ImageUrl = "manderines.jpg",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 12,
                Name = "Mangoes",
                Description = "",
                Price = 3.99M,
                ImageUrl = "mangoes.jpg",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 13,
                Name = "Pears",
                Description = "",
                Price = 3.99M,
                ImageUrl = "pears.jpg",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 14,
                Name = "Pineapples",
                Description = "",
                Price = 3.99M,
                ImageUrl = "pineapples.jpg",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 15,
                Name = "Pomegranates",
                Description = "",
                Price = 3.99M,
                ImageUrl = "pomegranates.jpg",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 16,
                Name = "Strawberries",
                Description = "",
                Price = 3.99M,
                ImageUrl = "strawberries.png",
            });
            builder.Entity<Product>().HasData(new Product
            {
                ProductId = 17,
                Name = "Watermelons",
                Description = "",
                Price = 3.99M,
                ImageUrl = "watermelons.jpg",
            });

            /*
             * COUPON SEED DATA
             */

            builder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                Code = "ORANGEUGR8",
                DiscountPercent = .5M,
                AppliesToProductIds = "2",
            });

            base.OnModelCreating(builder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Coupon> Coupons { get; set; }


    }
}
