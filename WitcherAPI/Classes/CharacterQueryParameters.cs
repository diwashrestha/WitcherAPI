using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherAPI.Classes
{
    public class CharacterQueryParameters :QueryParameters
    {
        public string Name { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
        public string Alias { get; set; }
        public string Race { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
    }
}
