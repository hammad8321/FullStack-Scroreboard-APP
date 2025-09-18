using Microsoft.EntityFrameworkCore;
using Scoreboard_api.Models;

namespace Scoreboard_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Player> PlayersDB { get; set; } // Initialize to null for EF Core compatibility



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Player>().HasData(
                new Player
                {
                    Id = 1,
                    Name = "PlayerZ",
                    Score = 25
                },
                new Player
                {
                    Id = 2,
                    Name = "PlayerX",
                    Score = 50
                });
        }

    }
}
