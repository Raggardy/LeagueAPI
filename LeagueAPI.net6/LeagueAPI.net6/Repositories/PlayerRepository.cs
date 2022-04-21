using LeagueAPI.net6.Contracts;
using LeagueAPI.net6.Data;
using LeagueAPI.net6.Models;
using Microsoft.EntityFrameworkCore;

namespace LeagueAPI.net6.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly FootballDbContext _footballDbContext;

        public PlayerRepository(FootballDbContext footballDbContext)
        {
            _footballDbContext = footballDbContext;
        }

        public bool Exists(int id)
        {
            return _footballDbContext.Players.Any(p => p.Id == id);
        }

        public async Task<ICollection<Player>> GetAllPlayersAsync()
        {
            return await _footballDbContext.Players.ToListAsync();
        }

        public async Task<Player> GetPlayerByIdAsync(int id)
        {
            return await _footballDbContext.Players
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync();
        }
    }
}
