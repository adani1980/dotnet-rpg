using Dotnet_rpg.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_rpg.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }
        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Name = "FireBall", Damage = 30 },
                new Skill { Id = 2, Name = "Frenzy" , Damage = 20},
                new Skill { Id = 3, Name = "Blizzard", Damage = 50 }
            );
            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, Brand = "Mercedes", Model ="Cls500" },
                new Car { Id = 2, Brand = "Audi", Model = "RS7" },
                new Car { Id = 3, Brand = "BMW", Model = "M7500RS" }
            );
        }
    }
}