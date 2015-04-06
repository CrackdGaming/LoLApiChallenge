using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDataModels.CurrentGame
{
    public class CurrentGameInfo
    {
        public List<BannedChampion> bannedChampions { get; set; }
        public long gameId { get; set; }
        public long gameLength { get; set; }
        public string gameMode { get; set; } //(Legal values: CLASSIC, ODIN, ARAM, TUTORIAL, ONEFORALL, ASCENSION, FIRSTBLOOD, KINGPORO)
        public long gameQueueConfigId { get; set; }
        public long gameStartTime { get; set; }
        public string gameType { get; set; }// (Legal values: CUSTOM_GAME, MATCHED_GAME, TUTORIAL_GAME)
        public long mapId { get; set; }
        public Observer observers { get; set; }
        public List<Participant> participants { get; set; }
        public string platformId { get; set; }
    }

    public class Participant
    {
        public bool bot { get; set; }
        public long championId { get; set; }
        public List<Mastery> masteries { get; set; }
        public long profileIconId { get; set; }
        public List<Rune> runes { get; set; }
        public long spell1Id { get; set; }
        public long spell2Id { get; set; }
        public long summonerId { get; set; }
        public string summonerName { get; set; }
        public long teamId { get; set; }
    }

    public class Rune
    {
        public int count { get; set; }
        public long runeId { get; set; }
    }

    public class Mastery
    {
        public long masteryId { get; set; }
        public int rank { get; set; }
    }

    public class Observer
    {
        public string encryptionKey { get; set; }
    }

    public class BannedChampion
    {
        public long championId { get; set; }
        public int pickTurn { get; set; }
        public long teamId { get; set; }
    }
}
