using Microsoft.EntityFrameworkCore;

namespace WitcherAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Character>().HasData(
                new Character { Id = 1, Name = "Geralt Of Rivia", Gender = "Male", EyeColor = "Amber", HairColor = "Milk- White", Race = "Human", Profession = "Witcher" },
                new Character { Id = 2, Name = "Emhyr var Emreis", Gender = "Male", EyeColor = "Brown", HairColor = "Black", Race = "Human", Nationality ="Lower Alba"});


        }
    }
}
