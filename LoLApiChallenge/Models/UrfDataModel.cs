using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoLApiChallenge.Models
{
    public class UrfDataModel
    {
        public List<FactionData> Factions { get; set; }
        public RootObject FullData { get; set; }
        public List<ChampionData> Champions { get; set; }
    }

    public class FactionData
    {
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
    }

    public class ChampionData
    {
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int TotalWins{ get; set; }
        public int TimesPicked { get; set; }
        public int MostDeaths { get; set; }
        
    }
}