using Microsoft.EntityFrameworkCore;

namespace WitcherAPI.Models
{
    public class WitcherContext :DbContext
    {
        public WitcherContext(DbContextOptions<WitcherContext> options)
            :base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
        public DbSet<Character> Characters { get; set; }


    }
}
