using LeagueAPI.net6.Contracts;
using LeagueAPI.net6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeagueAPI.net6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamRepository _teamRepository;

        public TeamsController(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type =typeof(IEnumerable<Team>))]
        public async Task <IActionResult> GetAllTeams()
        {
            var teams = await _teamRepository.GetAllTeamsAsync();
            return Ok(teams);
        }

        [HttpGet("{teamId}")]
        [ProducesResponseType(200, Type = typeof(Team))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetTeamById(int teamId)
        {
            var team = await _teamRepository.GetTeamByIdAsync(teamId);
            return Ok(team);
        }
    }
}
