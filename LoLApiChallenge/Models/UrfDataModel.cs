using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace LoLApiChallenge.Models
{
    public class UrfDataModel
    {
        public UrfDataModel()
        {
            Factions = new List<FactionData>();
            Champions = new List<ChampionData>();
        }
        public List<FactionData> Factions { get; set; }
        public RootObject FullData { get; set; }
        public List<ChampionData> Champions { get; set; }
    }

    public class FactionData
    {
        public Image Image { get; set; }
        public string Name { get; set; }
        public int TotalGames { get; set; }
        public int TotalKills { get; set; }
        public int TotalDeaths { get; set; }
        public int TotalAssists { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
    }

    public class ChampionData
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public int TotalGames { get; set;}
        public int TotalKills { get; set; }
        public int TotalDeaths { get; set; }
        public int TotalAssits { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int TotalWins{ get; set; }
        public int LargestCritStrike { get; set; }
        
    }
}