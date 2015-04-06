using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDataModels.Champion
{
    public class ChampionListDto
    {
        public List<ChampionDto> champions { get; set; }
    }

    public class ChampionDto
    {
        public bool active { get; set; }
        public bool botEnabled { get; set; }
        public bool botMmEnabled { get; set; }
        public bool freeToPlay { get; set; }
        public long id { get; set; }
        public bool rankedPlayEnabled { get; set; }
    }
}
