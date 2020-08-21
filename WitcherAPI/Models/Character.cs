using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherAPI.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
        public string Race { get; set; }
        //public string[] Title { get; set; }
        public string Profession { get; set; }
        //public string[] Abilities {get;set;}
        public string Description { get; set; }
    }
}
