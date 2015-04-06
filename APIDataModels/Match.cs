using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDataModels
{
    public class MatchDetail
    {
        public int mapId { get; set; }
        public long matchCreation { get; set; }
        public long matchDuration { get; set; }
        public long matchId { get; set; }
        public string matchMode { get; set; } //(Legal values: CLASSIC, ODIN, ARAM, TUTORIAL, ONEFORALL, ASCENSION, FIRSTBLOOD, KINGPORO)
        public string matchType { get; set; } //(Legal values: CUSTOM_GAME, MATCHED_GAME, TUTORIAL_GAME)
        public string matchVersion { get; set; }
        public List<ParticipantIdentity> participantIdentities { get; set; }
        public List<Participant> participants { get; set; }
        public string platformId { get; set; }
        public string queueType { get; set; } //(Legal values: CUSTOM, NORMAL_5x5_BLIND, RANKED_SOLO_5x5, RANKED_PREMADE_5x5, BOT_5x5, NORMAL_3x3, RANKED_PREMADE_3x3, NORMAL_5x5_DRAFT, ODIN_5x5_BLIND, ODIN_5x5_DRAFT, BOT_ODIN_5x5, BOT_5x5_INTRO, BOT_5x5_BEGINNER, BOT_5x5_INTERMEDIATE, RANKED_TEAM_3x3, RANKED_TEAM_5x5, BOT_TT_3x3, GROUP_FINDER_5x5, ARAM_5x5, ONEFORALL_5x5, FIRSTBLOOD_1x1, FIRSTBLOOD_2x2, SR_6x6, URF_5x5, ONEFORALL_MIRRORMODE_5x5, BOT_URF_5x5, NIGHTMARE_BOT_5x5_RANK1, NIGHTMARE_BOT_5x5_RANK2, NIGHTMARE_BOT_5x5_RANK5, ASCENSION_5x5, HEXAKILL, KING_PORO_5x5, COUNTER_PICK)
        public string region { get; set; }
        public string season { get; set; } //(Legal values: PRESEASON3, SEASON3, PRESEASON2014, SEASON2014, PRESEASON2015, SEASON2015)
        public List<Team> teams { get; set; }
        public Timeline timeline { get; set; }
    }

    public class Timeline
    {
        public long frameInterval { get; set; }
        public List<Frame> frames { get; set; }
    }

    public class Frame
    {
        public List<Event> events { get; set; }
        public Dictionary<string,ParticipantFrame> participantFrames { get; set; }
        public long timestamp { get; set; }
    }

    public class ParticipantFrame
    {
        public int currentGold { get; set; }
        public int dominionScore { get; set; }
        public int jungleMinionsKilled { get; set; }
        public int level { get; set; }
        public int minionsKilled { get; set; }
        public int participantId { get; set; }
        public Position position { get; set; }
        public int teamScore { get; set; }
        public int totalGold { get; set; }
        public int xp { get; set; }
    }

    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Event
    {
        public string ascendedType { get; set; } //(Legal values: CHAMPION_ASCENDED, CLEAR_ASCENDED, MINION_ASCENDED)
        public List<int> assistingParticipantIds { get; set; }
        public string buildingType { get; set; } //(Legal values: INHIBITOR_BUILDING, TOWER_BUILDING)
        public int creatorId { get; set; }
        public string eventType { get; set; } //(Legal values: ASCENDED_EVENT, BUILDING_KILL, CAPTURE_POINT, CHAMPION_KILL, ELITE_MONSTER_KILL, ITEM_DESTROYED, ITEM_PURCHASED, ITEM_SOLD, ITEM_UNDO, PORO_KING_SUMMON, SKILL_LEVEL_UP, WARD_KILL, WARD_PLACED)
        public int itemAfter { get; set; }
        public int itemBefore { get; set; }
        public int itemId { get; set; }
        public int killerId { get; set; } //Killer ID 0 indicates a minion.
        public string laneType { get; set; } //(Legal values: BOT_LANE, MID_LANE, TOP_LANE)
        public string levelUpType { get; set; } //(Legal values: EVOLVE, NORMAL)
        public string monsterType { get; set; } //(Legal values: BARON_NASHOR, BLUE_GOLEM, DRAGON, RED_LIZARD, VILEMAW)
        public int participantId { get; set; }
        public string pointCaptured { get; set; } //(Legal values: POINT_A, POINT_B, POINT_C, POINT_D, POINT_E)
        public Position position { get; set; }
        public int skillSlot { get; set; }
        public int teamId { get; set; }
        public long timestamp { get; set; }
        public string towerType { get; set; } //(Legal values: BASE_TURRET, FOUNTAIN_TURRET, INNER_TURRET, NEXUS_TURRET, OUTER_TURRET, UNDEFINED_TURRET)
        public int victimId { get; set; }
        public string wardType { get; set; } //(Legal values: SIGHT_WARD, TEEMO_MUSHROOM, UNDEFINED, VISION_WARD, YELLOW_TRINKET, YELLOW_TRINKET_UPGRADE)
    }

    public class Team
    {
        public List<BannedChampion> Type { get; set; }
        public int baronKills { get; set; }
        public long dominionVictoryScore { get; set; }
        public int dragonKills { get; set; }
        public bool firstBaron { get; set; }
        public bool firstBlood { get; set; }
        public bool firstDragon { get; set; }
        public bool firstInhibitor { get; set; }
        public bool firstTower { get; set; }
        public int inhibitorKills { get; set; }
        public int teamId { get; set; }
        public int towerKills { get; set; }
        public int vilemawKills { get; set; }
        public bool winner { get; set; }
    }

    public class BannedChampion
    {
        public int championId { get; set; }
        public int pickTurn { get; set; }
    }

    public class Rune
    {
        public long rank { get; set; }
        public long runeId { get; set; }
    }

    public class Mastery
    {
        public long masteryId { get; set; }
        public long rank { get; set; }
    }
    public class Participant
    {
        public int championId { get; set; }
        public string highestAchievedSeasonTier { get; set; }//(Legal values: CHALLENGER, MASTER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE, UNRANKED)
        public List<Mastery> masteries { get; set; }
        public int participantId { get; set; }
        public List<Rune> runes { get; set; }
        public int spell1Id { get; set; }
        public int spell2Id { get; set; }
        public ParticipantStats stats { get; set; }
        public int teamId { get; set; }
        public ParticipantTimeline timeline { get; set; }
    }

    public class ParticipantStats
    {
        public long assists { get; set; }
        public long champLevel { get; set; }
        public long combatPlayerScore { get; set; }
        public long deaths { get; set; }
        public long doubleKills { get; set; }
        public bool firstBloodAssist { get; set; }
        public bool firstBloodKill { get; set; }
        public bool firstInhibitorAssist { get; set; }
        public bool firstInhibitorKill { get; set; }
        public bool firstTowerAssist { get; set; }
        public bool firstTowerKill { get; set; }
        public long goldEarned { get; set; }
        public long goldSpent { get; set; }
        public long inhibitorKills { get; set; }
        public long item0 { get; set; }
        public long item1 { get; set; }
        public long item2 { get; set; }
        public long item3 { get; set; }
        public long item4 { get; set; }
        public long item5 { get; set; }
        public long item6 { get; set; }
        public long killingSprees { get; set; }
        public long kills { get; set; }
        public long largestCriticalStrike { get; set; }
        public long largestKillingSpree { get; set; }
        public long largestMultiKill { get; set; }
        public long magicDamageDealt { get; set; }
        public long magicDamageDealtToChampions { get; set; }
        public long magicDamageTaken { get; set; }
        public long minionsKilled { get; set; }
        public long neutralMinionsKilled { get; set; }
        public long neutralMinionsKilledEnemyJungle { get; set; }
        public long neutralMinionsKilledTeamJungle { get; set; }
        public long nodeCapture { get; set; }
        public long nodeCaptureAssist { get; set; }
        public long nodeNeutralize { get; set; }
        public long nodeNeutralizeAssist { get; set; }
        public long objectivePlayerScore { get; set; }
        public long pentaKills { get; set; }
        public long physicalDamageDealt { get; set; }
        public long physicalDamageDealtToChampions { get; set; }
        public long physicalDamageTaken { get; set; }
        public long quadraKills { get; set; }
        public long sightWardsBoughtInGame { get; set; }
        public long teamObjective { get; set; }
        public long totalDamageDealt { get; set; }
        public long totalDamageDealtToChampions { get; set; }
        public long totalDamageTaken { get; set; }
        public long totalHeal { get; set; }
        public long totalPlayerScore { get; set; }
        public long totalScoreRank { get; set; }
        public long totalTimeCrowdControlDealt { get; set; }
        public long totalUnitsHealed { get; set; }
        public long towerKills { get; set; }
        public long tripleKills { get; set; }
        public long trueDamageDealt { get; set; }
        public long trueDamageDealtToChampions { get; set; }
        public long trueDamageTaken { get; set; }
        public long unrealKills { get; set; }
        public long visionWardsBoughtInGame { get; set; }
        public long wardsKilled { get; set; }
        public long wardsPlaced { get; set; }
        public long winner { get; set; }
    }

    public class ParticipantIdentity
    {
        public int participantId { get; set; }
        public Player player { get; set; }
    }

    public class Player
    {
        public string matchHistoryUri { get; set; }
        public int profileIcon { get; set; }
        public long summonerId { get; set; }
        public string summonerName { get; set; }
    }

    public class ParticipantTimeline
    {
        public ParticipantTimelineData ancientGolemAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData ancientGolemKillsPerMinCounts { get; set; }
        public ParticipantTimelineData assistedLaneDeathsPerMinDeltas { get; set; }
        public ParticipantTimelineData assistedLaneKillsPerMinDeltas { get; set; }
        public ParticipantTimelineData baronAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData baronKillsPerMinCounts { get; set; }
        public ParticipantTimelineData creepsPerMinDeltas { get; set; }
        public ParticipantTimelineData csDiffPerMinDeltas { get; set; }
        public ParticipantTimelineData damageTakenDiffPerMinDeltas { get; set; }
        public ParticipantTimelineData damageTakenPerMinDeltas { get; set; }
        public ParticipantTimelineData dragonAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData dragonKillsPerMinCounts { get; set; }
        public ParticipantTimelineData elderLizardAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData elderLizardKillsPerMinCounts { get; set; }
        public ParticipantTimelineData goldPerMinDeltas { get; set; }
        public ParticipantTimelineData inhibitorAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData inhibitorKillsPerMinCounts { get; set; }
        public string lane { get; set; }//(Legal values: MID, MIDDLE, TOP, JUNGLE, BOT, BOTTOM)
        public string role { get; set; }//(Legal values: DUO, NONE, SOLO, DUO_CARRY, DUO_SUPPORT)
        public ParticipantTimelineData towerAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData towerKillsPerMinCounts { get; set; }
        public ParticipantTimelineData towerKillsPerMinDeltas { get; set; }
        public ParticipantTimelineData vilemawAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData vilemawKillsPerMinCounts { get; set; }
        public ParticipantTimelineData wardsPerMinDeltas { get; set; }
        public ParticipantTimelineData xpDiffPerMinDeltas { get; set; }
        public ParticipantTimelineData xpPerMinDeltas { get; set; }

    }

    public class ParticipantTimelineData
    {
        public double tenToTwenty { get; set; }
        public double thirtyToEnd { get; set; }
        public double twentyToThirty { get; set; }
        public double zeroToTen { get; set; }
    }
}
