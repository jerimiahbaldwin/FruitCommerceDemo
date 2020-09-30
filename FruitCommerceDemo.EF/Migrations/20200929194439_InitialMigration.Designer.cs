﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using FruitCommerceDemo.EF;

namespace FruitCommerceDemo.EF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200929194439_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FruitCommerceDemo.EF.Entities.Coupon", b =>
                {
                    b.Property<int>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppliesToProductIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DiscountPercent")
                        .HasColumnType("decimal(6,6)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("CouponId");

                    b.ToTable("Coupons");

                    b.HasData(
                        new
                        {
                            CouponId = 1,
                            AppliesToProductIds = "2",
                            Code = "ORANGEUGR8",
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(4173),
                            DiscountPercent = 0.5m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(4196)
                        });
                });

            modelBuilder.Entity("FruitCommerceDemo.EF.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 287, DateTimeKind.Local).AddTicks(7539),
                            Description = "That’s right: America’s favorite snacking apple is low-maintenance and ultra-productive, too. In fact, our larger Red Delicious varieties have already produced apples at our nursery.",
                            ImageUrl = "apples.png",
                            Name = "Red Delicious Apples",
                            Price = 5.00m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 292, DateTimeKind.Local).AddTicks(5006)
                        },
                        new
                        {
                            ProductId = 2,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(1738),
                            Description = "Extra-big, beautiful, seedless, very low in acid and filled with mild, sweet flesh. These beauties are supremely simple to peel and section. Bursting with freshly picked juiciness, this is the perfect orange to serve to kids. We also like to toss sections into fruit salad.",
                            ImageUrl = "oranges.png",
                            Name = "Navel Oranges",
                            Price = 10.00m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(1762)
                        },
                        new
                        {
                            ProductId = 3,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(1982),
                            Description = "",
                            ImageUrl = "avocados.jpg",
                            Name = "Avocados",
                            Price = 3.99m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(1989)
                        },
                        new
                        {
                            ProductId = 4,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2040),
                            Description = "",
                            ImageUrl = "bananas.jpg",
                            Name = "Bananas",
                            Price = 3.99m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2048)
                        },
                        new
                        {
                            ProductId = 5,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2095),
                            Description = "",
                            ImageUrl = "blueberries.jpg",
                            Name = "Blueberries",
                            Price = 3.99m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2103)
                        },
                        new
                        {
                            ProductId = 6,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2158),
                            Description = "",
                            ImageUrl = "cherries.jpg",
                            Name = "Cherries",
                            Price = 3.99m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2166)
                        },
                        new
                        {
                            ProductId = 7,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2213),
                            Description = "",
                            ImageUrl = "grapes.jpg",
                            Name = "Grapes",
                            Price = 3.99m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2221)
                        },
                        new
                        {
                            ProductId = 8,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2264),
                            Description = "",
                            ImageUrl = "kiwis.jpg",
                            Name = "Kiwis",
                            Price = 3.99m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2272)
                        },
                        new
                        {
                            ProductId = 9,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2315),
                            Description = "",
                            ImageUrl = "lemons.jpg",
                            Name = "Lemons",
                            Price = 3.99m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2323)
                        },
                        new
                        {
                            ProductId = 10,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2374),
                            Description = "",
                            ImageUrl = "limes.jpg",
                            Name = "Limes",
                            Price = 3.99m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2378)
                        },
                        new
                        {
                            ProductId = 11,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2425),
                            Description = "",
                            ImageUrl = "manderines.jpg",
                            Name = "Manderines",
                            Price = 3.99m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2429)
                        },
                        new
                        {
                            ProductId = 12,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2476),
                            Description = "",
                            ImageUrl = "mangoes.jpg",
                            Name = "Mangoes",
                            Price = 3.99m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2484)
                        },
                        new
                        {
                            ProductId = 13,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2527),
                            Description = "",
                            ImageUrl = "pears.jpg",
                            Name = "Pears",
                            Price = 3.99m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2535)
                        },
                        new
                        {
                            ProductId = 14,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2578),
                            Description = "",
                            ImageUrl = "pineapples.jpg",
                            Name = "Pineapples",
                            Price = 3.99m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2586)
                        },
                        new
                        {
                            ProductId = 15,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2629),
                            Description = "",
                            ImageUrl = "pomegranates.jpg",
                            Name = "Pomegranates",
                            Price = 3.99m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2637)
                        },
                        new
                        {
                            ProductId = 16,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2684),
                            Description = "",
                            ImageUrl = "strawberries.png",
                            Name = "Strawberries",
                            Price = 3.99m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2688)
                        },
                        new
                        {
                            ProductId = 17,
                            Created = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2736),
                            Description = "",
                            ImageUrl = "watermelons.jpg",
                            Name = "Watermelons",
                            Price = 3.99m,
                            Source = "WebApp",
                            Updated = new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2743)
                        });
                });

            modelBuilder.Entity("FruitCommerceDemo.EF.Entities.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("ShoppingCartId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("FruitCommerceDemo.EF.Entities.ShoppingCartCoupon", b =>
                {
                    b.Property<int>("ShoppingCartCouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CouponId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("int");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("ShoppingCartCouponId");

                    b.HasIndex("CouponId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("ShoppingCartCoupon");
                });

            modelBuilder.Entity("FruitCommerceDemo.EF.Entities.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("int");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("FruitCommerceDemo.EF.Entities.ShoppingCartCoupon", b =>
                {
                    b.HasOne("FruitCommerceDemo.EF.Entities.Coupon", "Coupon")
                        .WithMany()
                        .HasForeignKey("CouponId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FruitCommerceDemo.EF.Entities.ShoppingCart", "ShoppingCart")
                        .WithMany("Coupons")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FruitCommerceDemo.EF.Entities.ShoppingCartItem", b =>
                {
                    b.HasOne("FruitCommerceDemo.EF.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FruitCommerceDemo.EF.Entities.ShoppingCart", "ShoppingCart")
                        .WithMany("Items")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}