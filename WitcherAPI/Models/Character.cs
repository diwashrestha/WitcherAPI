using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherAPI.Models
{
    public class Character
    {
        public int CharId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }
        public string Hair { get; set; }
        public string Race { get; set; }
        public string Description { get; set; }
    }
}
