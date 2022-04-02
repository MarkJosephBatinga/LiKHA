using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Likha.Server.Migrations
{
    public partial class AddImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 4, 2, 9, 45, 32, 227, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 4, 2, 9, 45, 32, 232, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 4, 2, 9, 45, 32, 232, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 4, 2, 9, 45, 32, 232, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 4, 2, 9, 45, 32, 232, DateTimeKind.Local).AddTicks(323));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 4, 1, 11, 0, 16, 847, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 4, 1, 11, 0, 16, 851, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 4, 1, 11, 0, 16, 851, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 4, 1, 11, 0, 16, 851, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 4, 1, 11, 0, 16, 851, DateTimeKind.Local).AddTicks(7506));
        }
    }
}
