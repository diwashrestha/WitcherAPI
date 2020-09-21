using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherAPI.Models
{
    /// <summary>
    /// Character
    /// </summary>
    public class Character
    {
        /// <summary>
        ///  Guid id of the character
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Character Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Character Image
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Character Name Alias
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Character Hair Color
        /// </summary>
        public string HairColor { get; set; }

        /// <summary>
        /// Character Eye Color
        /// </summary>
        public string EyeColor { get; set; }

        /// <summary>
        /// Which race character belongs to
        /// </summary>
        public string Race { get; set; }

        /// <summary>
        /// Character gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Character nationality in witcher world
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// Titles character holding like king, duchy
        /// </summary>
        public string Titles { get; set; }

        /// <summary>
        /// Different ability of character
        /// </summary>
        public string Abilities { get; set; }

        /// <summary>
        /// Character Profession/Job
        /// </summary>
        public string Profession { get; set; }

        /// <summary>
        /// Information about the character
        /// </summary>
        public string Description { get; set; }
    }
}
