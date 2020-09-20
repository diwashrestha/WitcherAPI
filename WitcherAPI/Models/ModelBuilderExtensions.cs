using Microsoft.EntityFrameworkCore;
using System;

namespace WitcherAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Character>().HasData(
                //new Character { Id = 1, Name = "Geralt of Revia", ImageUrl = "https://raw.githubusercontent.com/diwashrestha/WitcherAPI/master/image/character/Geralt_of_Rivia.png", Alias ="null", HairColor = "Milk White", EyeColor = "Amber", Race = "Human", Gender="Male", Titles = "Knight" ,Abilities = "Swordsmanship, Alchemy, Signs ", Profession = "Witcher", Description = "Geralt of Rivia was a legendary witcher of the School of the Wolf active throughout the 13th century. He loved the sorceress Yennefer, considered the love of his life despite their tumultuous relationship, and became Ciri's adoptive father. During the Trial of the Grasses, Geralt exhibited unusual tolerance for the mutagens that grant witchers their abilities. Accordingly, Geralt was subjected to further experimental mutagens which rendered his hair white and may have given him greater speed, strength, and stamina than his fellow witchers.  Despite his title, Geralt did not hail from the city of Rivia. After being left with the witchers by his mother, Visenna, he grew up in their keep of Kaer Morhen in the realm of Kaedwen. In the interest of appearing more trustworthy to potential clients, young witchers were encouraged to make up surnames for themselves by master Vesemir. As his first choice, Geralt chose Geralt Roger Eric du Haute - Bellegarde, but this choice was dismissed by Vesemir as silly and pretentious, so Geralt was all that remained of his chosen name. Of Rivia was a more practical alternative and Geralt even went so far as to adopt a Rivian accent to appear more authentic. Later, Queen Meve of Lyria knighted him for his valor in the Battle for the Bridge on the Yaruga conferring on him the formal title of Rivia, which amused him.[1] He, therefore, became a true knight." });
        }
    }
}