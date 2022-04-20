using LeagueAPI.net6.Models;

namespace LeagueAPI.net6.Contracts
{
    public interface ITeamRepository
    {
        Task<ICollection<Team>> GetAllTeamsAsync();
        Task<Team> GetTeamByIdAsync(int id);
        Team GetTeamByName(string name);
        bool TeamExists(int id);
        bool CreateTeam(Team team);
        bool Save();

    }
}
