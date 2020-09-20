using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherAPI.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string VulnerableTo { get; set; }
        public string Occurrence { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
