using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherAPI.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Damage { get; set; }
        public string Effects { get; set; }
        public float Weight { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
