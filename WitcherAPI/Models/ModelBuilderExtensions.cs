using Microsoft.EntityFrameworkCore;
using System;

namespace WitcherAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(
                new Character { CharacterId = 1, Name = "Emhyr var Emreis", ImageUrl = "https://raw.githubusercontent.com/diwashrestha/WitcherAPI/master/image/character/Emhyr_var_Emreis.png", Alias ="null", HairColor = "Black", EyeColor = "Brown", Race = "Human", Gender="Male", Nationality = "Nelfgardian", Titles = "null" ,Abilities = "null", Profession = "Emperor of Nilfgaard", Description = "Emhyr var Emreis, Deithwen Addan yn Carn aep Morvudd (Nilfgaardian language: The White Flame Dancing on the Barrows of his Enemies), also known to a few under his alias as Duny, the Urcheon of Erlenwald  was Emperor of the Nilfgaardian Empire, Lord of Metinna, Ebbing, Gemmera, and Sovereign of Nazair and Vicovaro from 1257 until his death sometime in the late 13th century. He also became the King of Cintra after marrying Cirilla in 1268. His rule of Nilfgaard was highly aggressive, often pursuing expansionist policies similar to those of his predecessors. This led to the outbreak of two wars against the Northern Kingdoms, both of which he lost. Emhyr var Emreis was an intelligent and brilliant ruler. He chose his people well and crushed many plots against him. He was ruthless toward traitors and moved towards his goals with great determination.He was publicly favorable to the Elder Races, in stark contrast to monarchs of the North." });
        }
    }
}