using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace firstTry.Migrations
{
    public partial class orderrow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 1, 1, 13, 6, 58, 57, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2020, 1, 11, 13, 6, 58, 69, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2020, 1, 17, 13, 6, 58, 69, DateTimeKind.Local).AddTicks(1050));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 1, 1, 13, 2, 7, 974, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2020, 1, 11, 13, 2, 7, 985, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2020, 1, 17, 13, 2, 7, 985, DateTimeKind.Local).AddTicks(8360));
        }
    }
}
