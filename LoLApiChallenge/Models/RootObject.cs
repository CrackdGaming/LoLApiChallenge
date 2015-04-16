using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoLApiChallenge.Models
{
    public class Gold
    {
        public int mostGoldAccumulated { get; set; }
        public long totalGoldAccumulated { get; set; }
        public int mostGoldSpent { get; set; }
        public long totalGoldSpent { get; set; }
    }

    public class Kills
    {
        public int mostDeaths { get; set; }
        public int totalDeaths { get; set; }
        public int mostKills { get; set; }
        public int totalKills { get; set; }
        public int mostAssists { get; set; }
        public int totalAssists { get; set; }
        public int mostDoubleKills { get; set; }
        public int totalDoubleKills { get; set; }
        public int mostInhibitorKills { get; set; }
        public int totalInhibitorKills { get; set; }
        public int mostKillingSprees { get; set; }
        public int totalKillingSprees { get; set; }
        public int mostKillingSpree { get; set; }
        public int totalKillingSpree { get; set; }
        public int mostMultiKill { get; set; }
        public int totalMultiKills { get; set; }
        public int mostMinionsKilled { get; set; }
        public int totalMinionsKilled { get; set; }
        public int mostTowerKills { get; set; }
        public int totalTowerKills { get; set; }
        public int mostTripleKills { get; set; }
        public int totalTripleKills { get; set; }
    }

    public class Magic
    {
        public int mostMagicDamageDealt { get; set; }
        public long totalMagicDamageDealt { get; set; }
        public int mostMagicDamageDealtToChampions { get; set; }
        public long totalMagicDamageDealtToChampions { get; set; }
        public int mostMagicDamageTaken { get; set; }
        public long totalMagicDamageTaken { get; set; }
    }

    public class Physical
    {
        public int mostPhysicalDamageDealt { get; set; }
        public long totalPhysicalDamageDealt { get; set; }
        public int mostPhysicalDamageDealtToChampions { get; set; }
        public long totalPhysicalDamageDealtToChampions { get; set; }
        public int mostphysicalDamageTaken { get; set; }
        public long totalphysicalDamageTaken { get; set; }
    }

    public class Heal
    {
        public int mostHealing { get; set; }
        public long totalHealing { get; set; }
        public int mostUnitsHealed { get; set; }
        public int totalUnitsHealed { get; set; }
    }

    public class Damage
    {
        public int mostCriticalStrikeDamage { get; set; }
        public int totalCriticalStrikeDamage { get; set; }
        public int mostDamageDealt { get; set; }
        public long totalDamageDealt { get; set; }
        public int mostDamageDealtToChampions { get; set; }
        public long totalDamageDealtToChampions { get; set; }
        public int mostDamageTaken { get; set; }
        public long totalDamageTaken { get; set; }
        public Magic magic { get; set; }
        public Physical physical { get; set; }
        public Heal heal { get; set; }
    }

    public class Participant
    {
        public int totalChampLevels { get; set; }
        public int mostTimeCrowdControlDealt { get; set; }
        public int totalTimeCrowdControlDealt { get; set; }
        public Gold gold { get; set; }
        public Kills kills { get; set; }
        public Damage damage { get; set; }
    }

    public class Gold2
    {
        public int mostGoldAccumulated { get; set; }
        public int totalGoldAccumulated { get; set; }
        public int mostGoldSpent { get; set; }
        public int totalGoldSpent { get; set; }
    }

    public class Kills2
    {
        public int mostDeaths { get; set; }
        public int totalDeaths { get; set; }
        public int mostKills { get; set; }
        public int totalKills { get; set; }
        public int mostAssists { get; set; }
        public int totalAssists { get; set; }
        public int mostDoubleKills { get; set; }
        public int totalDoubleKills { get; set; }
        public int mostInhibitorKills { get; set; }
        public int totalInhibitorKills { get; set; }
        public int mostKillingSprees { get; set; }
        public int totalKillingSprees { get; set; }
        public int mostKillingSpree { get; set; }
        public int totalKillingSpree { get; set; }
        public int mostMultiKill { get; set; }
        public int totalMultiKills { get; set; }
        public int mostMinionsKilled { get; set; }
        public int totalMinionsKilled { get; set; }
        public int mostTowerKills { get; set; }
        public int totalTowerKills { get; set; }
        public int mostTripleKills { get; set; }
        public int totalTripleKills { get; set; }
    }

    public class Magic2
    {
        public int mostMagicDamageDealt { get; set; }
        public object totalMagicDamageDealt { get; set; }
        public int mostMagicDamageDealtToChampions { get; set; }
        public int totalMagicDamageDealtToChampions { get; set; }
        public int mostMagicDamageTaken { get; set; }
        public int totalMagicDamageTaken { get; set; }
    }

    public class Physical2
    {
        public int mostPhysicalDamageDealt { get; set; }
        public object totalPhysicalDamageDealt { get; set; }
        public int mostPhysicalDamageDealtToChampions { get; set; }
        public int totalPhysicalDamageDealtToChampions { get; set; }
        public int mostphysicalDamageTaken { get; set; }
        public int totalphysicalDamageTaken { get; set; }
    }

    public class Heal2
    {
        public int mostHealing { get; set; }
        public int totalHealing { get; set; }
        public int mostUnitsHealed { get; set; }
        public int totalUnitsHealed { get; set; }
    }

    public class Damage2
    {
        public int mostCriticalStrikeDamage { get; set; }
        public int totalCriticalStrikeDamage { get; set; }
        public int mostDamageDealt { get; set; }
        public object totalDamageDealt { get; set; }
        public int mostDamageDealtToChampions { get; set; }
        public int totalDamageDealtToChampions { get; set; }
        public int mostDamageTaken { get; set; }
        public int totalDamageTaken { get; set; }
        public Magic2 magic { get; set; }
        public Physical2 physical { get; set; }
        public Heal2 heal { get; set; }
    }

    public class Stat
    {
        public int totalChampLevels { get; set; }
        public int mostTimeCrowdControlDealt { get; set; }
        public int totalTimeCrowdControlDealt { get; set; }
        public Gold2 gold { get; set; }
        public Kills2 kills { get; set; }
        public Damage2 damage { get; set; }
    }

    public class Data
    {
        public int totalWins { get; set; }
        public int timesPicked { get; set; }
        public Stat stat { get; set; }
    }

    public class Champion
    {
        public int championId { get; set; }
        public Data data { get; set; }
    }

    public class Game
    {
        public int numGames { get; set; }
        public int mostMinutesPlayed { get; set; }
        public int totalMinutesPlayed { get; set; }
    }

    public class Championkill
    {
        public int killer { get; set; }
        public int victim { get; set; }
        public int kills { get; set; }
        public int assists { get; set; }
    }

    public class RootObject
    {
        public Participant participant { get; set; }
        public List<Champion> champions { get; set; }
        public List<object> heatmap { get; set; }
        public Game game { get; set; }
        public List<Championkill> championkills { get; set; }
    }
}