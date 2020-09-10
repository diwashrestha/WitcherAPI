using Microsoft.EntityFrameworkCore;

namespace WitcherAPI.Models
{
    public class WitcherDbContext :DbContext
    {
        public WitcherDbContext(DbContextOptions<WitcherDbContext> options)
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
