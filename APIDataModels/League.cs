using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDataModels
{
    public class LeagueDto
    {
        public List<LeagueEntryDto> entries { get; set; }
        public string name { get; set; }
        public string participantId { get; set; }
        public string queue { get; set; }//(Legal values: RANKED_SOLO_5x5, RANKED_TEAM_3x3, RANKED_TEAM_5x5)
        public string tier { get; set; }//(Legal values: CHALLENGER, MASTER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE)
    }

    public class LeagueEntryDto
    {
        public string division { get; set; }
        public bool isFreshBlood { get; set; }
        public bool isHotStreak { get; set; }
        public bool isInactive { get; set; }
        public bool isVeteran { get; set; }
        public int leaguePoints { get; set; }
        public int losses { get; set; }
        public MiniSeriesDto miniSeries { get; set; }
        public string playerOrTeamId { get; set; }
        public string playerOrTeamName { get; set; }
        public int wins { get; set; }
    }

    public class MiniSeriesDto
    {
        public int losses { get; set; }
        public string progress { get; set; }
        public int target { get; set; }
        public int wins { get; set; }
    }
}
