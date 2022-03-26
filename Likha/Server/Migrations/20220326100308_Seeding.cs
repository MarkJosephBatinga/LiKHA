using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Likha.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Paintings", "paintings" },
                    { 2, "Drawings", "drawings" },
                    { 3, "Digital Arts", "digital_arts" },
                    { 4, "Sculptures", "sculptures" },
                    { 5, "Ceramics", "ceramics" },
                    { 6, "Photography", "photography" },
                    { 7, "Designs", "designs" },
                    { 8, "Crafts", "crafts" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Artist", "CategoryId", "CategoryUrl", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Leonardo Da Vinci", 1, null, new DateTime(2022, 3, 26, 18, 3, 6, 301, DateTimeKind.Local).AddTicks(7463), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Famous Painting of Leonardo Da Vinci", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/Mona_Lisa%2C_by_Leonardo_da_Vinci%2C_from_C2RMF_retouched.jpg/1200px-Mona_Lisa%2C_by_Leonardo_da_Vinci%2C_from_C2RMF_retouched.jpg", false, false, 29000000m, "Monalisa" },
                    { 2, "Juan Luna", 2, null, new DateTime(2022, 3, 26, 18, 3, 6, 306, DateTimeKind.Local).AddTicks(5701), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Spoliarium is a painting by Filipino painter Juan Luna. Luna, working on canvas, spent eight months completing the painting which depicts dying gladiators.", "https://nolisoli.ph/wp-content/uploads/2018/08/IMG_3654.jpg", false, false, 3000000m, "Spolarium" },
                    { 3, "Vincent van Gogh", 3, null, new DateTime(2022, 3, 26, 18, 3, 6, 306, DateTimeKind.Local).AddTicks(5858), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Starry Night is an oil-on-canvas painting by the Dutch Post-Impressionist painter Vincent van Gogh. Painted in June 1889,", "https://www.vangoghgallery.com/img/starry_night_full.jpg", false, false, 4000000m, "The Starry Night" },
                    { 4, "Vincent van Gogh", 4, null, new DateTime(2022, 3, 26, 18, 3, 6, 306, DateTimeKind.Local).AddTicks(5867), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Girl with a Pearl Earring is an oil painting by Dutch Golden Age painter Johannes Vermeer, dated c. 1665. ,", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/1665_Girl_with_a_Pearl_Earring.jpg/800px-1665_Girl_with_a_Pearl_Earring.jpg", false, false, 2000000m, "Girl with a Pearl Earring" },
                    { 5, "Pablo Picasso", 5, null, new DateTime(2022, 3, 26, 18, 3, 6, 306, DateTimeKind.Local).AddTicks(5873), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guernica is a large 1937 oil painting on canvas by Spanish artist Pablo Picasso. It is one of his best-known works, regarded by many art critics as the most moving and powerful anti-war painting in history.", "https://upload.wikimedia.org/wikipedia/en/7/74/PicassoGuernica.jpg", false, false, 20000000m, "Guernica" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
