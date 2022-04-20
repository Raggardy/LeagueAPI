namespace LeagueAPI.net6.Models
{
    public class Team : Base
    {
        public string Name { get; set; }
        public string Stadium { get; set; }
        public string Manager { get; set; }
        public ICollection<Player> Players { get; set; }

    }
}
