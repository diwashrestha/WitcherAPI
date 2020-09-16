using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherAPI.Migrations
{
    public partial class ChracterModelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Characters",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://raw.githubusercontent.com/diwashrestha/WitcherAPI/master/image/character/Emhyr_var_Emreis.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Characters");
        }
    }
}
