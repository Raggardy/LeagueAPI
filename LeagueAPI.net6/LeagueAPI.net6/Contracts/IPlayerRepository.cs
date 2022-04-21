using LeagueAPI.net6.Models;

namespace LeagueAPI.net6.Contracts
{
    public interface IPlayerRepository
    {
        Task<ICollection<Player>> GetAllPlayersAsync();
        Task<Player> GetPlayerByIdAsync(int id);
        bool Exists(int id);
    }
}
