using LeagueAPI.net6.Models;
using Microsoft.EntityFrameworkCore;
using LeagueAPI.net6.Enums;

namespace LeagueAPI.net6.Data
{
    public class FootballDbContext : DbContext
    {
        public FootballDbContext(DbContextOptions<FootballDbContext> options) : base(options)
        {
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "Tortoise Town", Manager = "Tommy Turtle", Stadium = "Shell Stadium", },
                new Team { Id = 2, Name = "Bongo United", Manager = "Cyril Sneer", Stadium = "Stadium of Dark", });

            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 3, FirstName = "Doug", LastName = "Dig", Position = Position.GK, TeamId = 1 },
                new Player { Id = 4, FirstName = "Vince", LastName = "Van Douche", Position = Position.LB, TeamId = 1 },
                new Player { Id = 5, FirstName = "Tony", LastName = "Poloni", Position = Position.CB, TeamId = 1 },
                new Player { Id = 6, FirstName = "Rahn", LastName = "Barn", Position = Position.CB, TeamId = 1 },
                new Player { Id = 7, FirstName = "Clive", LastName = "Deek", Position = Position.RB, TeamId = 1 },
                new Player { Id = 8, FirstName = "Cedric", LastName = "Medric", Position = Position.LM, TeamId = 1 },
                new Player { Id = 9, FirstName = "Phil", LastName = "Chill", Position = Position.CM, TeamId = 1 },
                new Player { Id = 10, FirstName = "Mike", LastName = "Von Spike", Position = Position.RM, TeamId = 1 },
                new Player { Id = 11, FirstName = "Kevin", LastName = "Badger", Position = Position.CF, TeamId = 1 },
                new Player { Id = 12, FirstName = "Steve", LastName = "Badger", Position = Position.RW, TeamId = 1 },
                new Player { Id = 13, FirstName = "Zack", LastName = "Crack", Position = Position.LW, TeamId = 1 }

                );

        }
    }
    
}
