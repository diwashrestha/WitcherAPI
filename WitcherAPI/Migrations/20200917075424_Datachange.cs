using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherAPI.Migrations
{
    public partial class Datachange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://raw.githubusercontent.com/diwashrestha/WitcherAPI/master/image/character/Geralt_of_Rivia.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://github.com/diwashrestha/WitcherAPI/blob/master/image/character/Geralt_of_Rivia.png");
        }
    }
}
