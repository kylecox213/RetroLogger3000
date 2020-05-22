using RetroLogger3000.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RetroLogger3000.DAL
{
    public class RetroContext : DbContext
    {

        public RetroContext() : base("RetroContext")
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameConsole> GameConsoles { get; set; }
        public DbSet<GamePad> GamePads { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}