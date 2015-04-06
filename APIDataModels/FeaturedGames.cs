using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIDataModels.CurrentGame;

namespace APIDataModels
{
    public class FeaturedGames
    {
        public long clientRefreshInterval { get; set; }
        public List<CurrentGameInfo> gameList { get; set; }
    }
}
