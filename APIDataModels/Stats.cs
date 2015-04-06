using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDataModels
{
    public class PlayerStatsSummaryListDto
    {
        public List<PlayerStatsSummaryDto> playerStatSummaries { get; set; }
        public long summonerId { get; set; }
    }

    public class PlayerStatsSummaryDto
    {
        public AggregatedStatsDto aggregatedStats { get; set; }
        public int losses { get; set; }
        public long modifyDate { get; set; }
        public string playerStatSummaryType { get; set; } //(Legal values: AramUnranked5x5, CoopVsAI, CoopVsAI3x3, OdinUnranked, RankedPremade3x3, RankedPremade5x5, RankedSolo5x5, RankedTeam3x3, RankedTeam5x5, Unranked, Unranked3x3, OneForAll5x5, FirstBlood1x1, FirstBlood2x2, SummonersRift6x6, CAP5x5, URF, URFBots, NightmareBot, Ascension, Hexakill, KingPoro, CounterPick)
        public int wins { get; set; }

    }

    public class RankedStatsDto
    {
        public List<ChampionStatsDto> champions { get; set; }
        public long modifyDate { get; set; }
        public long summonerId { get; set; }
    }

    public class ChampionStatsDto
    {
        public int id { get; set; }
        public AggregatedStatsDto stats { get; set; }
    }

    public class AggregatedStatsDto
    {
        public int averageAssists { get; set; }
        public int averageChampionsKilled { get; set; }
        public int averageCombatPlayerScore { get; set; }
        public int averageNodeCapture { get; set; }
        public int averageNodeCaptureAssist { get; set; }
        public int averageNodeNeutralize { get; set; }
        public int averageNodeNeutralizeAssist { get; set; }
        public int averageNumDeaths { get; set; }
        public int averageObjectivePlayerScore { get; set; }
        public int averageTeamObjective { get; set; }
        public int averageTotalPlayerScore { get; set; }
        public int botGamesPlayed { get; set; }
        public int killingSpree { get; set; }
        public int maxAssists { get; set; }
        public int maxChampionsKilled { get; set; }
        public int maxCombatPlayerScore { get; set; }
        public int maxLargestCriticalStrike { get; set; }
        public int maxLargestKillingSpree { get; set; }
        public int maxNodeCapture { get; set; }
        public int maxNodeCaptureAssist { get; set; }
        public int maxNodeNeutralize { get; set; }
        public int maxNodeNeutralizeAssist { get; set; }
        public int maxNumDeaths { get; set; }
        public int maxObjectivePlayerScore { get; set; }
        public int maxTeamObjective { get; set; }
        public int maxTimePlayed { get; set; }
        public int maxTimeSpentLiving { get; set; }
        public int maxTotalPlayerScore { get; set; }
        public int mostChampionKillsPerSession { get; set; }
        public int mostSpellsCast { get; set; }
        public int normalGamesPlayed { get; set; }
        public int rankedPremadeGamesPlayed { get; set; }
        public int rankedSoloGamesPlayed { get; set; }
        public int totalAssists { get; set; }
        public int totalChampionKills { get; set; }
        public int totalDamageDealt { get; set; }
        public int totalDamageTaken { get; set; }
        public int totalDeathsPerSession { get; set; }
        public int totalDoubleKills { get; set; }
        public int totalFirstBlood { get; set; }
        public int totalGoldEarned { get; set; }
        public int totalHeal { get; set; }
        public int totalMagicDamageDealt { get; set; }
        public int totalMinionKills { get; set; }
        public int totalNeutralMinionsKilled { get; set; }
        public int totalNodeCapture { get; set; }
        public int totalNodeNeutralize { get; set; }
        public int totalPentaKills { get; set; }
        public int totalPhysicalDamageDealt { get; set; }
        public int totalQuadraKills { get; set; }
        public int totalSessionsLost { get; set; }
        public int totalSessionsPlayed { get; set; }
        public int totalSessionsWon { get; set; }
        public int totalTripleKills { get; set; }
        public int totalTurretsKilled { get; set; }
        public int totalUnrealKills { get; set; }
    }
}
