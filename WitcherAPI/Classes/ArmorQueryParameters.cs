using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherAPI.Classes
{
    public class ArmorQueryParameters:QueryParameters
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public float Weight { get; set; }
        public int Price { get; set; }
    }
}
