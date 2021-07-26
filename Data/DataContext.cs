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
    }
}