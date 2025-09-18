using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Scoreboard_api.Migrations
{
    /// <inheritdoc />
    public partial class Seeddatabse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayersDB",
                columns: new[] { "Id", "Name", "Score" },
                values: new object[,]
                {
                    { 1, "PlayerZ", 25 },
                    { 2, "PlayerX", 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayersDB",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlayersDB",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
