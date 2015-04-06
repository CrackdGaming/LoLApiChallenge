using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using APIDataModels.CurrentGame;
using APIDataModels.MatchHistory;
using APIDataModels.Static;
using APIDataModels.Static.Language;
using Newtonsoft.Json;

namespace APIDataModels
{
    public class LoLApiGenerator
    {
        #region Properties
        private string _baseUrl = "https://na.api.pvp.net/";
        public string ApiKey { get; set; }
        public string BaseUrl {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }
        #endregion

        #region Constructors
        public LoLApiGenerator(string apiKey)
        {
            ApiKey = apiKey;
        }

        public LoLApiGenerator(string apiKey, string baseUrl)
        {
            ApiKey = apiKey;
            _baseUrl = baseUrl;
        }
        #endregion

        #region Champions
        public Champion.ChampionListDto GetChampions(Region region)
        {
            string url = string.Format("{0}api/lol/{1}/v1.2/champion?api_key={2}", _baseUrl, region, ApiKey);
            string details = CallRestMethod(url);

            
            var result =
                   JsonConvert.DeserializeObject<Champion.ChampionListDto>(details);
            return result;
        }

        public Champion.ChampionListDto GetChampions(Region region, bool freeToPlay)
        {
            string url = string.Format("{0}api/lol/{1}/v1.2/champion?api_key={2}&freeToPlay={3}", _baseUrl, region, ApiKey, freeToPlay);
            string details = CallRestMethod(url);

            
            var result =
                   JsonConvert.DeserializeObject<Champion.ChampionListDto>(details);
            return result;
        }

        public Champion.ChampionDto GetChampion(Region region, int id)
        {
            string url = string.Format("{0}api/lol/{1}/v1.2/champion/{2}?api_key={3}", _baseUrl, region,id, ApiKey);
            string details = CallRestMethod(url);

            
            var result =
                   JsonConvert.DeserializeObject<Champion.ChampionDto>(details);
            return result;
        }
        #endregion

        #region Current Game
        public CurrentGameInfo GetSpectatorGameInfo(PlatformId platformId, long summonerId)
        {
            string url = string.Format("{0}observer-mode/rest/consumer/getSpectatorGameInfo/{1}/{2}?api_key={3}", _baseUrl, platformId, summonerId, ApiKey);
            string details = CallRestMethod(url);

            
            var result =
                   JsonConvert.DeserializeObject<CurrentGameInfo>(details);
            return result;
        }
        #endregion

        #region Featured Games

        public FeaturedGames GetFeaturedGames()
        {
            string url = string.Format("{0}observer-mode/rest/featured?api_key={1}", _baseUrl, ApiKey);
            string details = CallRestMethod(url);

            
            var result =
                   JsonConvert.DeserializeObject<FeaturedGames>(details);
            return result;
        }

        #endregion

        #region Game
        public RecentGamesDto GetRecentGames(Region region, long summonerId)
        {
            string url = string.Format("{0}api/lol/{1}/v1.3/game/by-summoner/{2}/recent?api_key={3}", _baseUrl,region,summonerId, ApiKey);
            string details = CallRestMethod(url);

            
            var result =
                   JsonConvert.DeserializeObject<RecentGamesDto>(details);
            return result;
        }
        #endregion

        #region League

        public Dictionary<string, List<LeagueDto>> GetSummonersLeagues(Region region, string summonerIds)
        {
            string url = string.Format("{0}api/lol/{1}/v2.5/league/by-summoner/{2}?api_key={3}", _baseUrl, region, summonerIds, ApiKey);
            string details = CallRestMethod(url);

            
            var result =
                   JsonConvert.DeserializeObject<Dictionary<string, List<LeagueDto>>>(details);
            return result;
        }

        public Dictionary<string, List<LeagueDto>> GetSummonersLeagueEntries(Region region, string summonerIds)
        {
            string url = string.Format("{0}api/lol/{1}/v2.5/league/by-summoner/{2}/entry?api_key={3}", _baseUrl, region, summonerIds, ApiKey);
            string details = CallRestMethod(url);

            
            var result =
                   JsonConvert.DeserializeObject<Dictionary<string, List<LeagueDto>>>(details);
            return result;
        }

        public Dictionary<string, List<LeagueDto>> GetSummonersLeagueByTeamIds(Region region, string teamIds)
        {
            string url = string.Format("{0}api/lol/{1}/v2.5/league/by-team/{2}?api_key={3}", _baseUrl, region, teamIds, ApiKey);
            string details = CallRestMethod(url);

            
            var result =
                   JsonConvert.DeserializeObject<Dictionary<string, List<LeagueDto>>>(details);
            return result;
        }
        
        public Dictionary<string, List<LeagueDto>> GetSummonersLeagueByTeamIdsEntry(Region region, string teamIds)
        {
            string url = string.Format("{0}api/lol/{1}/v2.5/league/by-team/{2}/entry?api_key={3}", _baseUrl, region, teamIds, ApiKey);
            string details = CallRestMethod(url);

            
            var result =
                   JsonConvert.DeserializeObject<Dictionary<string, List<LeagueDto>>>(details);
            return result;
        }

        public LeagueDto GetChallengerLeague(Region region, LeagueType type)
        {
            string url = string.Format("{0}api/lol/{1}/v2.5/league/challenger?type={2}&api_key={3}", _baseUrl, region, type, ApiKey);
            string details = CallRestMethod(url);

            
            var result =
                   JsonConvert.DeserializeObject<LeagueDto>(details);
            return result;
        }
        #endregion

        #region Static Data

        public Static.Champion.ChampionListDto GetChampionsDetail(Region region, string locale = "", string version = "", bool? dataById = null, string champData = "")
        {
            string url = string.Format("{0}api/lol/static-data/{1}/v1.2/champion?api_key={2}{3}{4}{5}{6}", _baseUrl, region, ApiKey,
                string.IsNullOrEmpty(locale) ? "" : "&locale=" + locale,
                string.IsNullOrEmpty(version) ? "" : "&version=" + version,
                (dataById == null) ? "" : "&dataById=" + dataById,
                string.IsNullOrEmpty(champData) ? "" : "&champData=" + champData);
            string details = CallRestMethod(url);

            
            var result =
                   JsonConvert.DeserializeObject<Static.Champion.ChampionListDto>(details);
            return result;
        }

        public Static.Champion.ChampionDto GetChampionDetailById(Region region, int id, string locale = "", string version = "", string champData = "")
        {
            string url = string.Format("{0}api/lol/static-data/{1}/v1.2/champion/{2}?api_key={3}{4}{5}{6}", _baseUrl, region,id, ApiKey,
                string.IsNullOrEmpty(locale) ? "" : "&locale=" + locale,
                string.IsNullOrEmpty(version) ? "" : "&version=" + version,
                string.IsNullOrEmpty(champData) ? "" : "&champData=" + champData);
            string details = CallRestMethod(url);

            
            var result =
                   JsonConvert.DeserializeObject<Static.Champion.ChampionDto>(details);
            return result;
        }

        public Static.Item.ItemListDto GetItems(Region region, string locale = "", string version = "", string itemListData = "")
        {
            string url = string.Format("{0}api/lol/static-data/{1}/v1.2/item?api_key={2}{3}{4}{5}", _baseUrl, region, ApiKey,
                string.IsNullOrEmpty(locale) ? "" : "&locale=" + locale,
                string.IsNullOrEmpty(version) ? "" : "&version=" + version,
                string.IsNullOrEmpty(itemListData) ? "" : "&itemListData=" + itemListData);
            string details = CallRestMethod(url);

            
            var result =
                   JsonConvert.DeserializeObject<Static.Item.ItemListDto>(details);
            return result;
        }

        public Static.Item.ItemDto GetItemById(Region region, int id, string locale = "", string version = "", string itemData = "")
        {
            string url = string.Format("{0}api/lol/static-data/{1}/v1.2/item/{2}?api_key={3}{4}{5}{6}", _baseUrl, region, id,ApiKey,
                string.IsNullOrEmpty(locale) ? "" : "&locale=" + locale,
                string.IsNullOrEmpty(version) ? "" : "&version=" + version,
                string.IsNullOrEmpty(itemData) ? "" : "&itemData=" + itemData);
            string details = CallRestMethod(url);

            
            var result =
                   JsonConvert.DeserializeObject<Static.Item.ItemDto>(details);
            return result;
        }

        public LanguageStringsDto GetLanguageStrings(Region region, string locale = "", string version = "")
        {
            string url = string.Format("{0}api/lol/static-data/{1}/v1.2/language-strings?api_key={2}{3}{4}", _baseUrl, region, ApiKey,
                string.IsNullOrEmpty(locale) ? "" : "&locale=" + locale,
                string.IsNullOrEmpty(version) ? "" : "&version=" + version);
            string details = CallRestMethod(url);


            var result =
                   JsonConvert.DeserializeObject<LanguageStringsDto>(details);
            return result;
        }

        public List<string> GetLanguages(Region region)
        {
            string url = string.Format("{0}api/lol/static-data/{1}/v1.2/languages?api_key={2}{3}{4}", _baseUrl, region, ApiKey);
            string details = CallRestMethod(url);


            var result =
                   JsonConvert.DeserializeObject<List<string>>(details);
            return result;
        }
        
        public MapDataDto GetMaps(Region region, string locale = "", string version = "")
        {
            string url = string.Format("{0}api/lol/static-data/{1}/v1.2/map?api_key={2}{3}{4}", _baseUrl, region, ApiKey,
                string.IsNullOrEmpty(locale) ? "" : "&locale=" + locale,
                string.IsNullOrEmpty(version) ? "" : "&version=" + version);
            string details = CallRestMethod(url);


            var result =
                   JsonConvert.DeserializeObject<MapDataDto>(details);
            return result;
        }

        public MasteryListDto GetMastery(Region region, string locale = "", string version = "", string masteryListData = "")
        {
            string url = string.Format("{0}api/lol/static-data/{1}/v1.2/mastery?api_key={2}{3}{4}{5}", _baseUrl, region, ApiKey,
                string.IsNullOrEmpty(locale) ? "" : "&locale=" + locale,
                string.IsNullOrEmpty(version) ? "" : "&version=" + version,
                string.IsNullOrEmpty(masteryListData) ? "" : "&masteryListData=" + masteryListData);
            string details = CallRestMethod(url);


            var result =
                   JsonConvert.DeserializeObject<MasteryListDto>(details);
            return result;
        }

        public MasteryDto GetMasteryById(Region region, int id, string locale = "", string version = "", string masteryData = "")
        {
            string url = string.Format("{0}api/lol/static-data/{1}/v1.2/mastery/{2}?api_key={3}{4}{5}{6}", _baseUrl, region,id, ApiKey,
                string.IsNullOrEmpty(locale) ? "" : "&locale=" + locale,
                string.IsNullOrEmpty(version) ? "" : "&version=" + version,
                string.IsNullOrEmpty(masteryData) ? "" : "&masteryData=" + masteryData);
            string details = CallRestMethod(url);


            var result =
                   JsonConvert.DeserializeObject<MasteryDto>(details);
            return result;
        }

        public RealmDto GetRealm(Region region)
        {
            string url = string.Format("{0}api/lol/static-data/{1}/v1.2/realm?api_key={2}", _baseUrl, region, ApiKey);
            string details = CallRestMethod(url);


            var result =
                   JsonConvert.DeserializeObject<RealmDto>(details);
            return result;
        }

        public RuneListDto GetRune(Region region, string locale = "", string version = "", string runeListData = "")
        {
            string url = string.Format("{0}api/lol/static-data/{1}/v1.2/rune?api_key={2}{3}{4}{5}", _baseUrl, region,  ApiKey,
                string.IsNullOrEmpty(locale) ? "" : "&locale=" + locale,
                string.IsNullOrEmpty(version) ? "" : "&version=" + version,
                string.IsNullOrEmpty(runeListData) ? "" : "&runeListData=" + runeListData);
            string details = CallRestMethod(url);


            var result =
                   JsonConvert.DeserializeObject<RuneListDto>(details);
            return result;
        }

        public RuneDto GetRuneById(Region region, int id, string locale = "", string version = "", string runeData = "")
        {
            string url = string.Format("{0}api/lol/static-data/{1}/v1.2/rune{2}?api_key={3}{4}{5}{6}", _baseUrl, region,id, ApiKey,
                string.IsNullOrEmpty(locale) ? "" : "&locale=" + locale,
                string.IsNullOrEmpty(version) ? "" : "&version=" + version,
                string.IsNullOrEmpty(runeData) ? "" : "&runeData=" + runeData);
            string details = CallRestMethod(url);


            var result =
                   JsonConvert.DeserializeObject<RuneDto>(details);
            return result;
        }

        public SummonerSpellListDto GetSummonerSpells(Region region,  string locale = "", string version = "",bool? dataById = null, string spellData = "")
        {
            string url = string.Format("{0}api/lol/static-data/{1}/v1.2/summoner-spell?api_key={2}{3}{4}{5}{6}", _baseUrl, region, ApiKey,
                string.IsNullOrEmpty(locale) ? "" : "&locale=" + locale,
                string.IsNullOrEmpty(version) ? "" : "&version=" + version,
                (dataById == null) ? "" : "&dataById=" + dataById,
                string.IsNullOrEmpty(spellData) ? "" : "&spellData=" + spellData);
            string details = CallRestMethod(url);


            var result =
                   JsonConvert.DeserializeObject<SummonerSpellListDto>(details);
            return result;
        }

        public SummonerSpellDto GetSummonerSpellsById(Region region, int id,string locale = "", string version = "",  string spellData = "")
        {
            string url = string.Format("{0}api/lol/static-data/{1}/v1.2/summoner-spell/{2}?api_key={3}{4}{5}{6}", _baseUrl, region,id, ApiKey,
                string.IsNullOrEmpty(locale) ? "" : "&locale=" + locale,
                string.IsNullOrEmpty(version) ? "" : "&version=" + version,
                string.IsNullOrEmpty(spellData) ? "" : "&spellData=" + spellData);
            string details = CallRestMethod(url);


            var result =
                   JsonConvert.DeserializeObject<SummonerSpellDto>(details);
            return result;
        }

        public List<string> GetVersions(Region region)
        {
            string url = string.Format("{0}api/lol/static-data/{1}/v1.2/versions?api_key={2}", _baseUrl, region, ApiKey);
            string details = CallRestMethod(url);


            var result =
                   JsonConvert.DeserializeObject<List<string>>(details);
            return result;
        }

        #endregion

        #region Status

        public List<Shard> Shard()
        {
            string url = string.Format("{0}shards?api_key={1}", _baseUrl,ApiKey);
            string details = CallRestMethod(url);


            var result =
                   JsonConvert.DeserializeObject<List<Shard>>(details);
            return result;
        }

        public ShardStatus Shard(Region region)
        {
            string url = string.Format("{0}shards/{1}?api_key={2}", _baseUrl,region, ApiKey);
            string details = CallRestMethod(url);


            var result =
                   JsonConvert.DeserializeObject<ShardStatus>(details);
            return result;
        }

        #endregion

        #region Match

        public MatchDetail GetMatchByMatchId(Region region, long matchId, bool? includeTimeline = null)
        {
            string url = string.Format("{0}api/lol/{1}/v2.2/match/{2}?api_key={3}{4}", _baseUrl, region, matchId, ApiKey,
                includeTimeline == null ? "" : "&includeTimeline=" + includeTimeline);
            string details = CallRestMethod(url);


            var result =
                   JsonConvert.DeserializeObject<MatchDetail>(details);
            return result;
        }

        public PlayerHistory GetMatchHistory(Region region, long summonerId, string championIds = "", string rankedQueues = "", int? beginIndex = null, int? endIndex = null)
        {
            string url = string.Format("{0}api/lol/{1}/v2.2/match/{2}?api_key={3}{4}{5}{6}{7}", _baseUrl, region, summonerId, ApiKey,
                string.IsNullOrEmpty(championIds) ? "" : "&championIds" + championIds,
                string.IsNullOrEmpty(rankedQueues) ? "" : "&rankedQueues" + rankedQueues,
                beginIndex == null ? "" : "&beginIndex=" + beginIndex,
                endIndex == null ? "" : "&endIndex=" + endIndex);
            string details = CallRestMethod(url);

            var result =
                   JsonConvert.DeserializeObject<PlayerHistory>(details);
            return result;
        }

        #endregion

        #region Stats

        public RankedStatsDto GetRankedStatsById(Region region, long summonerId, string season = "")
        {
            string url = string.Format("{0}api/lol/{1}/v1.3/stats/by-summoner/{2}/ranked?api_key={3}{4}", _baseUrl, region, summonerId, ApiKey,
                string.IsNullOrEmpty(season) ? "" : "&season" + season);
            string details = CallRestMethod(url);

            var result =
                   JsonConvert.DeserializeObject<RankedStatsDto>(details);
            return result;
        }

        public PlayerStatsSummaryListDto GetStatSummaryById(Region region, long summonerId, string season = "")
        {
            string url = string.Format("{0}api/lol/{1}/v1.3/stats/by-summoner/{2}/summary?api_key={3}{4}", _baseUrl, region, summonerId, ApiKey,
                string.IsNullOrEmpty(season) ? "" : "&season" + season);
            string details = CallRestMethod(url);

            var result =
                   JsonConvert.DeserializeObject<PlayerStatsSummaryListDto>(details);
            return result;
        }

        #endregion

        #region Summoner

        public Dictionary<string,SummonerDto> GetSummonerByName(Region region, string summonerNames)
        {
            string url = string.Format("{0}api/lol/{1}/v1.4/summoner/by-name/{2}?api_key={3}", _baseUrl, region, summonerNames, ApiKey);
            string details = CallRestMethod(url);

            var result =
                   JsonConvert.DeserializeObject<Dictionary<string, SummonerDto>>(details);
            return result;
        }

        public Dictionary<string, SummonerDto> GetSummonerById(Region region, string summonerIds)
        {
            string url = string.Format("{0}api/lol/{1}/v1.4/summoner/{2}?api_key={3}", _baseUrl, region, summonerIds, ApiKey);
            string details = CallRestMethod(url);

            var result =
                   JsonConvert.DeserializeObject<Dictionary<string, SummonerDto>>(details);
            return result;
        }

        public Dictionary<string, MasteryPagesDto> GetSummonerMasteries(Region region, string summonerIds)
        {
            string url = string.Format("{0}api/lol/{1}/v1.4/summoner/{2}/masteries?api_key={3}", _baseUrl, region, summonerIds, ApiKey);
            string details = CallRestMethod(url);

            var result =
                   JsonConvert.DeserializeObject<Dictionary<string, MasteryPagesDto>>(details);
            return result;
        }

        public Dictionary<string, string> GetSummonerNamesById(Region region, string summonerIds)
        {
            string url = string.Format("{0}api/lol/{1}/v1.4/summoner/{2}/name?api_key={3}", _baseUrl, region, summonerIds, ApiKey);
            string details = CallRestMethod(url);

            var result =
                   JsonConvert.DeserializeObject<Dictionary<string, string>>(details);
            return result;
        }

        public Dictionary<string, RunePagesDto> GetSummonerRunes(Region region, string summonerIds)
        {
            string url = string.Format("{0}api/lol/{1}/v1.4/summoner/{2}/runes?api_key={3}", _baseUrl, region, summonerIds, ApiKey);
            string details = CallRestMethod(url);

            var result =
                   JsonConvert.DeserializeObject<Dictionary<string, RunePagesDto>>(details);
            return result;
        }

        #endregion

        #region Team

        public Dictionary<string, List<TeamDto>> GetTeamBySummonerId(Region region, string summonerIds)
        {
            string url = string.Format("{0}api/lol/{1}/v2.4/team/by-summoner/{2}?api_key={3}", _baseUrl, region, summonerIds, ApiKey);
            string details = CallRestMethod(url);

            var result =
                   JsonConvert.DeserializeObject<Dictionary<string, List<TeamDto>>>(details);
            return result;
        }

        public Dictionary<string, TeamDto> GetTeamByTeamId(Region region, string teamIds)
        {
            string url = string.Format("{0}api/lol/{1}/v2.4/team/{2}?api_key={3}", _baseUrl, region, teamIds, ApiKey);
            string details = CallRestMethod(url);

            var result =
                   JsonConvert.DeserializeObject<Dictionary<string, TeamDto>>(details);
            return result;
        }

        #endregion

        #region NURF

        public List<long> ApiChallenge(Region region, long beginDate)
        {
            string url = string.Format("{0}api/lol/{1}/v4.1/game/ids?beginDate={2}&api_key={3}", _baseUrl, region,beginDate, ApiKey);
            string details = CallRestMethod(url);

            var result =
                   JsonConvert.DeserializeObject<List<long>>(details);
            return result;
        }


        #endregion

        #region Helpers
        private static string CallRestMethod(string url)
        {
            var result = "";
            try
            {
                var webrequest = (HttpWebRequest) WebRequest.Create(url);
                webrequest.Method = "GET";
                //webrequest.ContentType = "application/x-www-form-urlencoded";
                webrequest.ContentType = "application/json";

                var webresponse = (HttpWebResponse) webrequest.GetResponse();
                var enc = System.Text.Encoding.GetEncoding("utf-8");
                var responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
                result = responseStream.ReadToEnd();
                webresponse.Close();
            }
            catch (WebException we)
            {
                
            }
            return result;
        }
        #endregion
    }
}
