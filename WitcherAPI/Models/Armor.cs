using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherAPI.Models
{
    /// <summary>
    /// Armor in the game
    /// </summary>
    public class Armor
    {
        /// <summary>
        /// Guid id for the armor
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the armor
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type of the armor like medium armor, light armor
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Category in which the armor belongs
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Amount of protection it give to Geralt
        /// </summary>
        public string Protection { get; set; }

        /// <summary>
        /// Effects of wearing the armor on geralt
        /// </summary>
        public string Effects { get; set; }

        /// <summary>
        /// Weight of the armor
        /// </summary>
        public float Weight { get; set; }

        /// <summary>
        /// Price of the armor
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// image Url for the armor
        /// </summary>
        public string ImageUrl { get; set; }

    }
}
