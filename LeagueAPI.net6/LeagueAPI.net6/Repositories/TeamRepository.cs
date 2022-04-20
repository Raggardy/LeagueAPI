using LeagueAPI.net6.Contracts;
using LeagueAPI.net6.Data;
using LeagueAPI.net6.Models;
using Microsoft.EntityFrameworkCore;

namespace LeagueAPI.net6.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly FootballDbContext _footballContext;

        public TeamRepository(FootballDbContext footballContext)
        {
            _footballContext = footballContext;
        }


        public bool CreateTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Team>> GetAllTeamsAsync()
        {
            return await _footballContext.Teams.ToListAsync();
        }

        public async Task<Team> GetTeamByIdAsync(int id)
        {
            return await _footballContext.Teams
                .Where(t => t.Id == id)
                .FirstOrDefaultAsync();
        }

        public Team GetTeamByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool TeamExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
