using LeagueAPI.net6.Enums;

namespace LeagueAPI.net6.Models
{
    public class Player : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position Position { get; set; }
        public Team Team { get; set; }
        public int TeamId { get; set; }
    }
}
