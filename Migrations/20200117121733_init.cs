using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace firstTry.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Shape = table.Column<string>(nullable: true)
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
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    SurfboardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colors_Surfboards_SurfboardId",
                        column: x => x.SurfboardId,
                        principalTable: "Surfboards",
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
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderRows", x => x.Id);
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
                table: "Surfboards",
                columns: new[] { "Id", "Shape" },
                values: new object[] { 1, "Gun" });

            migrationBuilder.InsertData(
                table: "Surfboards",
                columns: new[] { "Id", "Shape" },
                values: new object[] { 2, "Fish" });

            migrationBuilder.InsertData(
                table: "Surfboards",
                columns: new[] { "Id", "Shape" },
                values: new object[] { 3, "Shortboard" });

            migrationBuilder.InsertData(
                table: "Surfboards",
                columns: new[] { "Id", "Shape" },
                values: new object[] { 4, "Longboard" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name", "SurfboardId" },
                values: new object[] { 2, "Grey", 2 });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name", "SurfboardId" },
                values: new object[] { 3, "Black", 2 });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name", "SurfboardId" },
                values: new object[] { 1, "Pink", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Colors_SurfboardId",
                table: "Colors",
                column: "SurfboardId");

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
                name: "Colors");

            migrationBuilder.DropTable(
                name: "OrderRows");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Surfboards");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
