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
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<Weapon> Weapons { get;set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

    }
}
