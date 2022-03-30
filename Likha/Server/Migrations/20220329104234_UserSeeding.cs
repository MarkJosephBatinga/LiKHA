using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Likha.Server.Migrations
{
    public partial class UserSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 29, 18, 42, 32, 323, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 29, 18, 42, 32, 327, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 29, 18, 42, 32, 327, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 29, 18, 42, 32, 327, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 29, 18, 42, 32, 327, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Password", "Phone", "Username" },
                values: new object[] { 1, "Alusiis, San Narciso, Zambales", "Mark", "Batinga", "Mark", "09501109163", "ShyGuy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 28, 14, 59, 6, 68, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 28, 14, 59, 6, 70, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 28, 14, 59, 6, 70, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 28, 14, 59, 6, 70, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 28, 14, 59, 6, 70, DateTimeKind.Local).AddTicks(5164));
        }
    }
}
