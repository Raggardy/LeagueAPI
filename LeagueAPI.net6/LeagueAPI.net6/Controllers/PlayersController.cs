using LeagueAPI.net6.Contracts;
using LeagueAPI.net6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeagueAPI.net6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayersController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Player>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetAllPlayers()
        {
            var players = await _playerRepository.GetAllPlayersAsync(); 
            return Ok(players);
        }

        [HttpGet("{playerId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Player>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetPlayerById(int playerId) 
        {
            var player = await _playerRepository.GetPlayerByIdAsync(playerId);
            return Ok(player);
        }
    }
}
