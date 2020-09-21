using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherAPI.Models
{
    /// <summary>
    /// Monster
    /// </summary>
    public class Monster
    {
        /// <summary>
        /// Guid id of the Monster
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the weapon
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// family group in which monster belongs to
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        ///  Things which can inflict extra damage to the monster
        /// </summary>
        public string VulnerableTo { get; set; }

        /// <summary>
        /// Name of the places where they can be found in wither world
        /// </summary>
        public string Occurrence { get; set; }

        /// <summary>
        /// Short description about the monster
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Image of the monster
        /// </summary>
        public string ImageUrl { get; set; }
    }
}
