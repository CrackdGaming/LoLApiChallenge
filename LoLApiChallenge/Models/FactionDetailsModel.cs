using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoLApiChallenge.Models
{
    public class FactionDetailsModel
    {
        public FactionDetailsModel()
        {
            Champs = new List<ChampionData>();
        }
        public string Name { get; set; }
        public List<ChampionData> Champs { get; set; }
    }
}