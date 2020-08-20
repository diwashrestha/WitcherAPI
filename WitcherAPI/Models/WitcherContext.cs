using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherAPI.Models
{
    public class WitcherContext :DbContext
    {
        public WitcherContext(DbContextOptions<WitcherContext> options)
            :base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
    }
}
