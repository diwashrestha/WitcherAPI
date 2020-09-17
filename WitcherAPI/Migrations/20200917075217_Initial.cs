using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherAPI.Migrations
{
    public partial class Initial : Migration
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
                    ImageUrl = table.Column<string>(nullable: true),
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
                columns: new[] { "CharacterId", "Abilities", "Alias", "Description", "EyeColor", "Gender", "HairColor", "ImageUrl", "Name", "Nationality", "Profession", "Race", "Titles" },
                values: new object[] { 1, "Swordsmanship, Alchemy, Signs ", "null", "Geralt of Rivia was a legendary witcher of the School of the Wolf active throughout the 13th century. He loved the sorceress Yennefer, considered the love of his life despite their tumultuous relationship, and became Ciri's adoptive father. During the Trial of the Grasses, Geralt exhibited unusual tolerance for the mutagens that grant witchers their abilities. Accordingly, Geralt was subjected to further experimental mutagens which rendered his hair white and may have given him greater speed, strength, and stamina than his fellow witchers.  Despite his title, Geralt did not hail from the city of Rivia. After being left with the witchers by his mother, Visenna, he grew up in their keep of Kaer Morhen in the realm of Kaedwen. In the interest of appearing more trustworthy to potential clients, young witchers were encouraged to make up surnames for themselves by master Vesemir. As his first choice, Geralt chose Geralt Roger Eric du Haute - Bellegarde, but this choice was dismissed by Vesemir as silly and pretentious, so Geralt was all that remained of his chosen name. Of Rivia was a more practical alternative and Geralt even went so far as to adopt a Rivian accent to appear more authentic. Later, Queen Meve of Lyria knighted him for his valor in the Battle for the Bridge on the Yaruga conferring on him the formal title of Rivia, which amused him.[1] He, therefore, became a true knight.", "Amber", "Male", "Milk White", "https://github.com/diwashrestha/WitcherAPI/blob/master/image/character/Geralt_of_Rivia.png", "Geralt of Revia", null, "Witcher", "Human", "Knight" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
