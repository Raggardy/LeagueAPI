using LeagueAPI.net6.Models;
using Microsoft.EntityFrameworkCore;

namespace LeagueAPI.net6.Data
{
    public class FootballDbContext : DbContext
    {
        public FootballDbContext(DbContextOptions<FootballDbContext> options) : base(options)
        {
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
