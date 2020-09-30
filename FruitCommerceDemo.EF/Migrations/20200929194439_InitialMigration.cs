using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FruitCommerceDemo.EF.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    CouponId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Source = table.Column<string>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(6,6)", nullable: false),
                    AppliesToProductIds = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.CouponId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Source = table.Column<string>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    ShoppingCartId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Source = table.Column<string>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    SessionId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.ShoppingCartId);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartCoupon",
                columns: table => new
                {
                    ShoppingCartCouponId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Source = table.Column<string>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    ShoppingCartId = table.Column<int>(nullable: false),
                    CouponId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartCoupon", x => x.ShoppingCartCouponId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartCoupon_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "CouponId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartCoupon_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "ShoppingCartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Source = table.Column<string>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    ShoppingCartId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "ShoppingCartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "AppliesToProductIds", "Code", "Created", "DiscountPercent", "Source", "Updated" },
                values: new object[] { 1, "2", "ORANGEUGR8", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(4173), 0.5m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Created", "Description", "ImageUrl", "Name", "Price", "Source", "Updated" },
                values: new object[,]
                {
                    { 15, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2629), "", "pomegranates.jpg", "Pomegranates", 3.99m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2637) },
                    { 14, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2578), "", "pineapples.jpg", "Pineapples", 3.99m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2586) },
                    { 13, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2527), "", "pears.jpg", "Pears", 3.99m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2535) },
                    { 12, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2476), "", "mangoes.jpg", "Mangoes", 3.99m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2484) },
                    { 11, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2425), "", "manderines.jpg", "Manderines", 3.99m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2429) },
                    { 10, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2374), "", "limes.jpg", "Limes", 3.99m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2378) },
                    { 9, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2315), "", "lemons.jpg", "Lemons", 3.99m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2323) },
                    { 8, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2264), "", "kiwis.jpg", "Kiwis", 3.99m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2272) },
                    { 7, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2213), "", "grapes.jpg", "Grapes", 3.99m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2221) },
                    { 6, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2158), "", "cherries.jpg", "Cherries", 3.99m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2166) },
                    { 5, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2095), "", "blueberries.jpg", "Blueberries", 3.99m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2103) },
                    { 4, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2040), "", "bananas.jpg", "Bananas", 3.99m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2048) },
                    { 3, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(1982), "", "avocados.jpg", "Avocados", 3.99m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(1989) },
                    { 2, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(1738), "Extra-big, beautiful, seedless, very low in acid and filled with mild, sweet flesh. These beauties are supremely simple to peel and section. Bursting with freshly picked juiciness, this is the perfect orange to serve to kids. We also like to toss sections into fruit salad.", "oranges.png", "Navel Oranges", 10.00m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(1762) },
                    { 1, new DateTime(2020, 9, 29, 13, 44, 39, 287, DateTimeKind.Local).AddTicks(7539), "That’s right: America’s favorite snacking apple is low-maintenance and ultra-productive, too. In fact, our larger Red Delicious varieties have already produced apples at our nursery.", "apples.png", "Red Delicious Apples", 5.00m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 292, DateTimeKind.Local).AddTicks(5006) },
                    { 16, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2684), "", "strawberries.png", "Strawberries", 3.99m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2688) },
                    { 17, new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2736), "", "watermelons.jpg", "Watermelons", 3.99m, "WebApp", new DateTime(2020, 9, 29, 13, 44, 39, 295, DateTimeKind.Local).AddTicks(2743) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartCoupon_CouponId",
                table: "ShoppingCartCoupon",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartCoupon_ShoppingCartId",
                table: "ShoppingCartCoupon",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ShoppingCartId",
                table: "ShoppingCartItems",
                column: "ShoppingCartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartCoupon");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");
        }
    }
}
