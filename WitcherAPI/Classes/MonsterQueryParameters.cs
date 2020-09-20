using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherAPI.Classes
{
    public class MonsterQueryParameters:QueryParameters
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Occurrence { get; set; }
        public string VulnerableTo { get; set; }
    }
}
