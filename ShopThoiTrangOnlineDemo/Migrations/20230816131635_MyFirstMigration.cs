using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopThoiTrangOnlineDemo.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_OrderEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TypePayment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_OrderEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_ProductCategoryEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SeoGhiChu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SeoKeywords = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ProductCategoryEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_ProductEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceSale = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    IsHome = table.Column<bool>(type: "bit", nullable: false),
                    IsSale = table.Column<bool>(type: "bit", nullable: false),
                    IsFeature = table.Column<bool>(type: "bit", nullable: false),
                    IsHot = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ProductCategoryID = table.Column<int>(type: "int", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SeoGhiChu = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    SeoKeywords = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProductCategoryEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ProductEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_ProductEntity_tb_ProductCategoryEntity_ProductCategoryEntityId",
                        column: x => x.ProductCategoryEntityId,
                        principalTable: "tb_ProductCategoryEntity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tb_OrderDetailEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderEntityId = table.Column<int>(type: "int", nullable: true),
                    ProductEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_OrderDetailEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_OrderDetailEntity_tb_OrderEntity_OrderEntityId",
                        column: x => x.OrderEntityId,
                        principalTable: "tb_OrderEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tb_OrderDetailEntity_tb_ProductEntity_ProductEntityId",
                        column: x => x.ProductEntityId,
                        principalTable: "tb_ProductEntity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tb_ProductImageEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    ProductEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ProductImageEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_ProductImageEntity_tb_ProductEntity_ProductEntityId",
                        column: x => x.ProductEntityId,
                        principalTable: "tb_ProductEntity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_OrderDetailEntity_OrderEntityId",
                table: "tb_OrderDetailEntity",
                column: "OrderEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_OrderDetailEntity_ProductEntityId",
                table: "tb_OrderDetailEntity",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_ProductEntity_ProductCategoryEntityId",
                table: "tb_ProductEntity",
                column: "ProductCategoryEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_ProductImageEntity_ProductEntityId",
                table: "tb_ProductImageEntity",
                column: "ProductEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_OrderDetailEntity");

            migrationBuilder.DropTable(
                name: "tb_ProductImageEntity");

            migrationBuilder.DropTable(
                name: "tb_OrderEntity");

            migrationBuilder.DropTable(
                name: "tb_ProductEntity");

            migrationBuilder.DropTable(
                name: "tb_ProductCategoryEntity");
        }
    }
}
