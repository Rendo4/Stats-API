namespace Stats.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Summoner { get; set; }
        public string Team { get; set; }
        public int Opponent { get; set; }
        public string Champion { get; set; }
        public string KDA { get; set; }
    }
}