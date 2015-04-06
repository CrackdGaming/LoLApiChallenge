using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDataModels
{
    public class TeamDto
    {
        public long createDate { get; set; }
        public string fullId { get; set; }
        public long lastGameDate { get; set; }
        public long lastJoinDate { get; set; }
        public long lastJoinedRankedTeamQueueDate { get; set; }
        public List<MatchHistorySummaryDto> matchHistory { get; set; }
        public long modifyDate { get; set; }
        public string name { get; set; }
        public RosterDto roster { get; set; }
        public long secondLastJoinDate { get; set; }
        public string status { get; set; }
        public string tag { get; set; }
        public List<TeamStatDetailDto> teamStatDetails { get; set; }
        public long thirdLastJoinDate { get; set; }
    }

    public class TeamStatDetailDto
    {
        public int averageGamesPlayed { get; set; }
        public int losses { get; set; }
        public string teamStatType { get; set; }
        public int wins { get; set; }
    }

    public class RosterDto
    {
        public List<TeamMemberInfoDto> memberList { get; set; }
        public long ownerId { get; set; }
    }

    public class TeamMemberInfoDto
    {
        public long inviteDate { get; set; }
        public long joinDate { get; set; }
        public long playerId { get; set; }
        public string status { get; set; }
    }


    public class MatchHistorySummaryDto
    {
        public int assists { get; set; }
        public long date { get; set; }
        public int deaths { get; set; }
        public long gameId { get; set; }
        public string gameMode { get; set; }
        public bool invalid { get; set; }
        public int kills { get; set; }
        public int mapId { get; set; }
        public int opposingTeamKills { get; set; }
        public string opposingTeamName { get; set; }
        public bool win { get; set; }
    }
}
