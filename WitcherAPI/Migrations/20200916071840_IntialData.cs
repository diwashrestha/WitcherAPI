using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherAPI.Migrations
{
    public partial class IntialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true),
                    HairColor = table.Column<string>(nullable: true),
                    EyeColor = table.Column<string>(nullable: true),
                    Race = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    Titles = table.Column<string>(nullable: true),
                    Abilities = table.Column<string>(nullable: true),
                    Profession = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Abilities", "Alias", "Description", "EyeColor", "Gender", "HairColor", "Name", "Nationality", "Profession", "Race", "Titles" },
                values: new object[] { 1, "null", "null", "Emhyr var Emreis, Deithwen Addan yn Carn aep Morvudd (Nilfgaardian language: The White Flame Dancing on the Barrows of his Enemies), also known to a few under his alias as Duny, the Urcheon of Erlenwald  was Emperor of the Nilfgaardian Empire, Lord of Metinna, Ebbing, Gemmera, and Sovereign of Nazair and Vicovaro from 1257 until his death sometime in the late 13th century. He also became the King of Cintra after marrying Cirilla in 1268. His rule of Nilfgaard was highly aggressive, often pursuing expansionist policies similar to those of his predecessors. This led to the outbreak of two wars against the Northern Kingdoms, both of which he lost. Emhyr var Emreis was an intelligent and brilliant ruler. He chose his people well and crushed many plots against him. He was ruthless toward traitors and moved towards his goals with great determination.He was publicly favorable to the Elder Races, in stark contrast to monarchs of the North.", "Brown", "Male", "Black", "Emhyr var Emreis", "Nelfgardian", "Emperor of Nilfgaard", "Human", "null" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
