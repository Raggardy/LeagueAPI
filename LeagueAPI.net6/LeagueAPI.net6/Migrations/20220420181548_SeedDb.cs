using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeagueAPI.net6.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Manager", "Name", "Stadium" },
                values: new object[] { 1, "Tommy Turtle", "Tortoise Town", "Shell Stadium" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Manager", "Name", "Stadium" },
                values: new object[] { 2, "Cyril Sneer", "Bongo United", "Stadium of Dark" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "FirstName", "LastName", "Position", "TeamId" },
                values: new object[,]
                {
                    { 3, "Doug", "Dig", 0, 1 },
                    { 4, "Vince", "Van Douche", 1, 1 },
                    { 5, "Tony", "Poloni", 3, 1 },
                    { 6, "Rahn", "Barn", 3, 1 },
                    { 7, "Clive", "Deek", 2, 1 },
                    { 8, "Cedric", "Medric", 4, 1 },
                    { 9, "Phil", "Chill", 5, 1 },
                    { 10, "Mike", "Von Spike", 6, 1 },
                    { 11, "Kevin", "Badger", 8, 1 },
                    { 12, "Steve", "Badger", 9, 1 },
                    { 13, "Zack", "Crack", 7, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
