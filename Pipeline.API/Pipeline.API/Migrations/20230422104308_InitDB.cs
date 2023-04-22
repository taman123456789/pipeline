using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pipeline.API.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Production");

            migrationBuilder.EnsureSchema(
                name: "Sales");

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "Production",
                columns: table => new
                {
                    Categories_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Categories_Name = table.Column<string>(type: "varchar(255)", unicode: false, nullable: false),
                    Categories_Parent = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Categories_Notes = table.Column<string>(type: "varchar(1000)", unicode: false, nullable: true),
                    Categories_SortOrder = table.Column<int>(type: "int", nullable: false),
                    Categories_Description = table.Column<string>(type: "varchar(4000)", unicode: false, nullable: true),
                    TimeFirst = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeLast = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Categories_Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                schema: "Sales",
                columns: table => new
                {
                    Customer_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    First_Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Last_Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Street = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    city = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    state = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Zip_Code = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    TimeFirst = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeLast = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Customer_Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Production",
                columns: table => new
                {
                    Products_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Products_Name = table.Column<string>(type: "varchar(100)", unicode: false, nullable: false),
                    Products_Description = table.Column<string>(type: "varchar(4000)", unicode: false, nullable: true),
                    Products_Notes = table.Column<string>(type: "varchar(4000)", unicode: false, nullable: true),
                    ProductUnitTypes_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Products_Accuracy = table.Column<string>(type: "varchar(50)", unicode: false, nullable: true),
                    Products_Rounding = table.Column<int>(type: "int", nullable: false),
                    Products_Waste = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Products_SupplementalToBid = table.Column<bool>(type: "bit", nullable: false),
                    Products_ProjectedCost = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Products_IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    TimeFirst = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeLast = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Products_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "Customers",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Production");
        }
    }
}
