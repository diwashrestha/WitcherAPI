using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherAPI.Models
{
    /// <summary>
    /// Different type of weapons used by Geralt
    /// </summary>
    public class Weapon
    {
        /// <summary>
        /// Guid id for weapon
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the Weapon
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Category of weapon like common, magic etc
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Define the type of weapon lik silver sword, crossbow etc
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Possible damage from the weapon
        /// </summary>
        public string Damage { get; set; }

        /// <summary>
        /// Effects while using weapon
        /// </summary>
        public string Effects { get; set; }

        /// <summary>
        /// Weight of the weapon
        /// </summary>
        public float Weight { get; set; }

        /// <summary>
        /// Base Price of the weapon
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Url of the weapon image
        /// </summary>
        public string ImageUrl { get; set; }
    }
}
