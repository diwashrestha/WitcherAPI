using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherAPI.Models
{
    public class Weapon
    {
        public int WeaponId { get; set; }
        public string WeaponName { get; set; }
        public string WeaponUrl { get; set; }
        public string WeaponCategory { get; set; }
        public string WeaponType { get; set; }
        public int WeaponPrice { get; set; }
        public int WeaponWeight { get; set; }
        public string[] WeaponEffects { get; set; }
    }
}
