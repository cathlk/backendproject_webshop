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
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surfboards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Shape = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
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
                    SizeId = table.Column<int>(nullable: false),
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
                        name: "FK_OrderRows_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
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
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "5'6" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "6'0" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "7'0" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "7'6" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "9'1" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "9'6" });

            migrationBuilder.InsertData(
                table: "Surfboards",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Shape" },
                values: new object[] { 1, "Denna brädan handlar om glid och flow med möjlighet för surfaren att vandra på brädan för maximal “nose riding time”. Av denna anledning är denna brädan lång, bredd och otroligt stabil. Om du är på jakt efter en riktigt rolig longboard att surfa down the line med så är Retro ditt val.", "https://shopcdn2.textalk.se/shop/26254/art54/h8795/22218795-origpic-567940.jpg?max-width=549&max-height=549&quality=85", 11403, "Longboard" });

            migrationBuilder.InsertData(
                table: "Surfboards",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Shape" },
                values: new object[] { 2, "En shortboard med longboard outline i framdelen! Fånga vågor är enkelt med denna bräda och den flatta rockern ger dig bästa glid. Bottenkurvan med pintail (samt subtil rocker vid tailen) ser till att du behåller full kontroll och manövrerbarhet. Inte nog med detta, Lovechild erbjuder dessutom 3 olika fin set up möjligheter. Single-fin, 2+1 eller quad!", "https://shopcdn2.textalk.se/shop/26254/art54/h7693/38987693-origpic-98a47a.jpg?max-width=549&max-height=549&quality=85", 2222, "Shortboard" });

            migrationBuilder.InsertData(
                table: "Surfboards",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Shape" },
                values: new object[] { 3, "Modern har blandat inslag av retrofish-shape från 70-talet tillsammans med en modern bottenstruktur samt med en quad-setup för att göra denna bräda till det optimala valet i små till medelstora vågor. Flow, smoothness och pure fun kännertecknar denna bräda.", "https://shopcdn2.textalk.se/shop/26254/art54/h4090/156144090-origpic-f52a2b.jpg?max-width=549&max-height=549&quality=85", 4325, "Hybrid" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate" },
                values: new object[] { 2, 1, new DateTime(2020, 1, 18, 13, 33, 9, 301, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate" },
                values: new object[] { 1, 2, new DateTime(2020, 1, 8, 13, 33, 9, 288, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate" },
                values: new object[] { 3, 3, new DateTime(2020, 1, 24, 13, 33, 9, 301, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.InsertData(
                table: "OrderRows",
                columns: new[] { "Id", "OrderId", "SizeId", "SurfBoardId" },
                values: new object[] { 4, 2, 5, 1 });

            migrationBuilder.InsertData(
                table: "OrderRows",
                columns: new[] { "Id", "OrderId", "SizeId", "SurfBoardId" },
                values: new object[] { 1, 1, 1, 2 });

            migrationBuilder.InsertData(
                table: "OrderRows",
                columns: new[] { "Id", "OrderId", "SizeId", "SurfBoardId" },
                values: new object[] { 2, 1, 2, 2 });

            migrationBuilder.InsertData(
                table: "OrderRows",
                columns: new[] { "Id", "OrderId", "SizeId", "SurfBoardId" },
                values: new object[] { 3, 1, 3, 3 });

            migrationBuilder.InsertData(
                table: "OrderRows",
                columns: new[] { "Id", "OrderId", "SizeId", "SurfBoardId" },
                values: new object[] { 5, 3, 4, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_OrderId",
                table: "OrderRows",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_SizeId",
                table: "OrderRows",
                column: "SizeId");

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
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Surfboards");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
