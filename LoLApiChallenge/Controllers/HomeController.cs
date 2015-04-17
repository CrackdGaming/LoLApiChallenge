using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APIDataModels;
using APIDataModels.Champion;
using LoLApiChallenge.Models;
using Microsoft.Ajax.Utilities;
using WebGrease.Css.Extensions;
using Region = APIDataModels.Region;

namespace LoLApiChallenge.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var model = new UrfDataModel
            {
                FullData = Data,
                TotalTimePlayed = 1.0 * Data.game.totalMinutesPlayed / 60,
                LongestGamePlayed = 1.0 * Data.game.mostMinutesPlayed / 60,
                AverageTime = 1.0 *Data.game.totalMinutesPlayed /Data.game.numGames / 60,
                TotalGamesPlayed = Data.game.numGames
            };

            foreach (string factionName in Factions.Keys)
            {
                FactionData factionData = new FactionData();
                factionData.Name = factionName;

                foreach (Champion champion in Data.champions)
                {
                    if (Factions[factionName].Contains(champion.championId))
                    {
                        factionData = AddTotals(champion.data.timesPicked, champion.data.stat.kills.totalKills,
                        champion.data.stat.kills.totalAssists, champion.data.stat.kills.totalDeaths, factionData);
                    }
                }

                factionData = AverageData(factionData);
                model.Factions.Add(factionData);
            }

            model.Factions = model.Factions.OrderByDescending(f => f.Kda).ToList();

            return View(model);
        }

        public List<ChampionData> GenerateChampionData()
        {
            var champions = new List<ChampionData>();
            foreach (var champ in Data.champions)
            {
                var key = ChampionKeys.FirstOrDefault(c => c.Value.id == champ.championId);
                var ch = new ChampionData
                {
                    Id = champ.championId,
                    Kills = champ.data.stat.kills.totalKills/champ.data.timesPicked,
                    Deaths = champ.data.stat.kills.totalDeaths/champ.data.timesPicked,
                    Assists = champ.data.stat.kills.totalAssists/champ.data.timesPicked,
                    TotalDeaths = champ.data.stat.kills.totalDeaths,
                    TotalGames = champ.data.timesPicked,
                    TotalKills = champ.data.stat.kills.totalKills,
                    TotalAssits = champ.data.stat.kills.totalAssists,
                    TotalWins = champ.data.totalWins,
                    LargestCritStrike = champ.data.stat.damage.mostCriticalStrikeDamage,
                    Name = key.Value.name,
                    ImageUrl = "http://ddragon.leagueoflegends.com/cdn/5.7.2/img/champion/" + key.Value.key + ".png",
                };
                ch.Kda = (ch.Kills *2) + (ch.Assists *1.5) + (ch.Deaths *-0.5);
                champions.Add(ch);
            }
            return champions.OrderByDescending(c =>c.Kda).ToList();
        }

        public JsonResult GetChampionData(int id)
        {
            var model = PopulateChampData(id);

            return Json(
                new
                {
                    data = RenderPartialViewToString("Partials/_ChampionDetails", model)
                }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetFactionData(string id)
        {
            var model = new FactionDetailsModel();

            Factions[id].ForEach(i => model.Champs.Add(PopulateChampData(i)));

            return Json(
                new
                {
                    data = RenderPartialViewToString("Partials/_FactionDetails", model)
                }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult LoadChampions()
        {
            var model = new UrfDataModel {Champions = GenerateChampionData()};

            return Json(
                new
                {
                    data = RenderPartialViewToString("Partials/_Champions", model)
                }, JsonRequestBehavior.AllowGet);
        }


        public ChampionData PopulateChampData(int id)
        {
            var model = new ChampionData();

            var champData = Data.champions.FirstOrDefault(c => c.championId == id);
            var key = ChampionKeys.FirstOrDefault(c => c.Value.id == id);
            model = new ChampionData
            {
                Id = champData.championId,
                Kills = champData.data.stat.kills.totalKills / champData.data.timesPicked,
                Deaths = champData.data.stat.kills.totalDeaths / champData.data.timesPicked,
                Assists = champData.data.stat.kills.totalAssists / champData.data.timesPicked,
                TotalDeaths = champData.data.stat.kills.totalDeaths,
                TotalGames = champData.data.timesPicked,
                TotalKills = champData.data.stat.kills.totalKills,
                TotalAssits = champData.data.stat.kills.totalAssists,
                TotalWins = champData.data.totalWins,
                LargestCritStrike = champData.data.stat.damage.mostCriticalStrikeDamage,
                Name = key.Value.name,
                ImageUrl = "http://ddragon.leagueoflegends.com/cdn/5.7.2/img/champion/" + key.Value.key + ".png",
            };
            model.Kda = (model.Kills * 2) + (model.Assists * 1.5) + (model.Deaths * -0.5);
            return model;
        }

        public ActionResult GetImage(string name)
        {
            return File(AppDomain.CurrentDomain.BaseDirectory + @"\Content\Images\Factions\"+name + ".jpg", "image/jpeg");
        }

        public FactionData AddTotals(int totalGames, int totalKills, int totalAssists, int totalDeaths, FactionData data)
        {
            data.TotalGames += totalGames;
            data.TotalKills += totalKills;
            data.TotalAssists += totalAssists;
            data.TotalDeaths += totalDeaths;
            return data;
        }

        public FactionData AverageData(FactionData faction)
        {
            faction.Kills = faction.TotalKills / faction.TotalGames;
            faction.Deaths = faction.TotalDeaths / faction.TotalGames;
            faction.Assists = faction.TotalAssists / faction.TotalGames;
            faction.Kda = (faction.Kills * 2) + (faction.Assists * 1.5) + (faction.Deaths * -0.5);
            return faction;
        }

        public ActionResult Map()
        {
            return View();
        }
    }
}