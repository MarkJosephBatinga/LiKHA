using Microsoft.EntityFrameworkCore.Migrations;

namespace Likha.Server.Migrations
{
    public partial class AddUserIdToCArt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Carts");
        }
    }
}
