using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherAPI.Models
{
    public class Armor
    {
        public int ArmorId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string ArmorType { get; set; }
        public string ArmorCategory { get; set; }
        public int ArmorPrice { get; set; }
        public int ArmorWeight { get; set; }
        public string[] ArmorEffects { get; set; }
    }
}
