using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace firstTry.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surfboards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Shape = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surfboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderRows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SurfBoardId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderRows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderRows_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderRows_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderRows_Surfboards_SurfBoardId",
                        column: x => x.SurfBoardId,
                        principalTable: "Surfboards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Pink" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Grey" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Black" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "FirstName", "LastName" },
                values: new object[] { 1, "Bells Beach, Victoria", "Tyler", "Wright" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "FirstName", "LastName" },
                values: new object[] { 2, "Saquarema, Rio", "Silvana", "Lima" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "FirstName", "LastName" },
                values: new object[] { 3, "Honolua Bay, Maui", "Mason", "Ho" });

            migrationBuilder.InsertData(
                table: "Surfboards",
                columns: new[] { "Id", "Price", "Shape" },
                values: new object[] { 1, 2345, "Gun" });

            migrationBuilder.InsertData(
                table: "Surfboards",
                columns: new[] { "Id", "Price", "Shape" },
                values: new object[] { 2, 4325, "Fish" });

            migrationBuilder.InsertData(
                table: "Surfboards",
                columns: new[] { "Id", "Price", "Shape" },
                values: new object[] { 3, 2222, "Shortboard" });

            migrationBuilder.InsertData(
                table: "Surfboards",
                columns: new[] { "Id", "Price", "Shape" },
                values: new object[] { 4, 11403, "Longboard" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate" },
                values: new object[] { 2, 1, new DateTime(2020, 1, 11, 13, 2, 7, 985, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate" },
                values: new object[] { 1, 2, new DateTime(2020, 1, 1, 13, 2, 7, 974, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate" },
                values: new object[] { 3, 3, new DateTime(2020, 1, 17, 13, 2, 7, 985, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.InsertData(
                table: "OrderRows",
                columns: new[] { "Id", "ColorId", "OrderId", "SurfBoardId" },
                values: new object[] { 4, 2, 2, 1 });

            migrationBuilder.InsertData(
                table: "OrderRows",
                columns: new[] { "Id", "ColorId", "OrderId", "SurfBoardId" },
                values: new object[] { 1, 1, 1, 2 });

            migrationBuilder.InsertData(
                table: "OrderRows",
                columns: new[] { "Id", "ColorId", "OrderId", "SurfBoardId" },
                values: new object[] { 2, 3, 1, 2 });

            migrationBuilder.InsertData(
                table: "OrderRows",
                columns: new[] { "Id", "ColorId", "OrderId", "SurfBoardId" },
                values: new object[] { 3, 1, 1, 3 });

            migrationBuilder.InsertData(
                table: "OrderRows",
                columns: new[] { "Id", "ColorId", "OrderId", "SurfBoardId" },
                values: new object[] { 5, 3, 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_ColorId",
                table: "OrderRows",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_OrderId",
                table: "OrderRows",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_SurfBoardId",
                table: "OrderRows",
                column: "SurfBoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderRows");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Surfboards");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
