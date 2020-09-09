using Microsoft.EntityFrameworkCore;

namespace WitcherAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(
                new Character { Id = 1, Name = "Geralt Of Rivia", EyeColor = "Amber", HairColor = "Milk- White", Race = "Human", Profession = "Witcher" , Description =" I am witcher",Nationality ="Nepali"});
        }
    }
}
