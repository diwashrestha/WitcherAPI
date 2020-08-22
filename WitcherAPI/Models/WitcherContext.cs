using Microsoft.EntityFrameworkCore;

namespace WitcherAPI.Models
{
    public class WitcherContext :DbContext
    {
        public WitcherContext(DbContextOptions<WitcherContext> options)
            :base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

    }
}
