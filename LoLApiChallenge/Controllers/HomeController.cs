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
using Region = APIDataModels.Region;

namespace LoLApiChallenge.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var model = new UrfDataModel{FullData = Data};
            var facBilgewater = new FactionData
            {
                Name = "Bilgewater"
            };
            var facBandleCity = new FactionData
            {
                Name = "Bandle City"
            };
            var facBlackRose = new FactionData
            {
                Name = "Black Rose"
            };
            var facDemacia = new FactionData
            {
                Name = "Demacia"
            };
            var facFreljord = new FactionData
            {
                Name = "Freljord"
            };
            var facIonia = new FactionData
            {
                Name = "Ionia"
            };
            var facIndependent = new FactionData
            {
                Name = "Independent"
            };
            var facMtTargon = new FactionData
            {
                Name = "Mount Targon"
            };
            var facNoxus = new FactionData
            {
                Name = "Noxus"
            };
            var facPiltover = new FactionData
            {
                Name = "Piltover"
            };
            var facShurima = new FactionData
            {
                Name = "Shurimas Desert"
            };
            var facShadowIsles = new FactionData
            {
                Name = "Shadow Isles"
            };
            var facTheVoid = new FactionData
            {
                Name = "The Void"
            };
            var facZaun = new FactionData
            {
                Name = "Zaun"
            };
            foreach (var champ in Data.champions)
            {
                if (Bilgewater.Contains(champ.championId) )
                {
                    facBilgewater = AddTotals(champ.data.timesPicked, champ.data.stat.kills.totalKills,
                        champ.data.stat.kills.totalAssists, champ.data.stat.kills.totalDeaths, facBilgewater);
                }
                if (BandleCity.Contains(champ.championId))
                {
                    facBandleCity = AddTotals(champ.data.timesPicked, champ.data.stat.kills.totalKills,
                        champ.data.stat.kills.totalAssists, champ.data.stat.kills.totalDeaths, facBandleCity);
                } 
                if (BlackRose.Contains(champ.championId))
                {
                    facBlackRose = AddTotals(champ.data.timesPicked, champ.data.stat.kills.totalKills,
                        champ.data.stat.kills.totalAssists, champ.data.stat.kills.totalDeaths, facBlackRose);
                }
                if (Demacia.Contains(champ.championId))
                {
                    facDemacia = AddTotals(champ.data.timesPicked, champ.data.stat.kills.totalKills,
                        champ.data.stat.kills.totalAssists, champ.data.stat.kills.totalDeaths, facDemacia);
                }
                if (Freljord.Contains(champ.championId))
                {
                    facFreljord = AddTotals(champ.data.timesPicked, champ.data.stat.kills.totalKills,
                        champ.data.stat.kills.totalAssists, champ.data.stat.kills.totalDeaths, facFreljord);
                }
                if (Ionia.Contains(champ.championId))
                {
                    facIonia = AddTotals(champ.data.timesPicked, champ.data.stat.kills.totalKills,
                        champ.data.stat.kills.totalAssists, champ.data.stat.kills.totalDeaths, facIonia);
                }
                if (Independent.Contains(champ.championId))
                {
                    facIndependent = AddTotals(champ.data.timesPicked, champ.data.stat.kills.totalKills,
                        champ.data.stat.kills.totalAssists, champ.data.stat.kills.totalDeaths, facIndependent);
                }
                if (MtTargon.Contains(champ.championId))
                {
                    facMtTargon = AddTotals(champ.data.timesPicked, champ.data.stat.kills.totalKills,
                        champ.data.stat.kills.totalAssists, champ.data.stat.kills.totalDeaths, facMtTargon);
                }
                if (Noxus.Contains(champ.championId))
                {
                    facNoxus = AddTotals(champ.data.timesPicked, champ.data.stat.kills.totalKills,
                        champ.data.stat.kills.totalAssists, champ.data.stat.kills.totalDeaths, facNoxus);
                }
                if (Piltover.Contains(champ.championId))
                {
                    facPiltover = AddTotals(champ.data.timesPicked, champ.data.stat.kills.totalKills,
                        champ.data.stat.kills.totalAssists, champ.data.stat.kills.totalDeaths, facPiltover);
                }
                if (Shurima.Contains(champ.championId))
                {
                    facShurima = AddTotals(champ.data.timesPicked, champ.data.stat.kills.totalKills,
                        champ.data.stat.kills.totalAssists, champ.data.stat.kills.totalDeaths, facShurima);
                }
                if (ShadowIsles.Contains(champ.championId))
                {
                    facShadowIsles = AddTotals(champ.data.timesPicked, champ.data.stat.kills.totalKills,
                        champ.data.stat.kills.totalAssists, champ.data.stat.kills.totalDeaths, facShadowIsles);
                }
                if (TheVoid.Contains(champ.championId))
                {
                    facTheVoid = AddTotals(champ.data.timesPicked, champ.data.stat.kills.totalKills,
                        champ.data.stat.kills.totalAssists, champ.data.stat.kills.totalDeaths, facTheVoid);
                }
                if (Zaun.Contains(champ.championId))
                {
                    facZaun = AddTotals(champ.data.timesPicked, champ.data.stat.kills.totalKills,
                        champ.data.stat.kills.totalAssists, champ.data.stat.kills.totalDeaths, facZaun);
                }
            }

            facBilgewater = AverageData(facBilgewater);
            facBandleCity = AverageData(facBandleCity);
            facBlackRose = AverageData(facBlackRose);
            facDemacia = AverageData(facDemacia);
            facFreljord = AverageData(facFreljord);
            facIonia = AverageData(facIonia);
            facIndependent = AverageData(facIndependent);
            facMtTargon = AverageData(facMtTargon);
            facNoxus = AverageData(facNoxus);
            facPiltover = AverageData(facPiltover);
            facShurima = AverageData(facShurima);
            facShadowIsles = AverageData(facShadowIsles);
            facTheVoid = AverageData(facTheVoid);
            facZaun = AverageData(facZaun);

            model.Factions.Add(facZaun);
            model.Factions.Add(facBilgewater);
            model.Factions.Add(facBandleCity);
            model.Factions.Add(facBlackRose);
            model.Factions.Add(facDemacia);
            model.Factions.Add(facFreljord);
            model.Factions.Add(facIndependent);
            model.Factions.Add(facIonia);
            model.Factions.Add(facMtTargon);
            model.Factions.Add(facNoxus);
            model.Factions.Add(facPiltover);
            model.Factions.Add(facShadowIsles);
            model.Factions.Add(facShurima);
            model.Factions.Add(facTheVoid);
            model.Factions = model.Factions.OrderByDescending(f => f.Kills).ToList();

            model.Champions = GenerateChampionData();
            return View(model);
        }

        public List<ChampionData> GenerateChampionData()
        {
            var champions = new List<ChampionData>();
            foreach (var champ in Data.champions)
            {
                var key = ChampionKeys.FirstOrDefault(c => c.Value.id == champ.championId);
                champions.Add(new ChampionData
                {
                    Id = champ.championId,
                    Kills =champ.data.stat.kills.totalKills / champ.data.timesPicked,
                    Deaths= champ.data.stat.kills.totalDeaths/ champ.data.timesPicked,
                    Assists = champ.data.stat.kills.totalAssists / champ.data.timesPicked,
                    TotalDeaths = champ.data.stat.kills.totalDeaths,
                    TotalGames = champ.data.timesPicked,
                    TotalKills = champ.data.stat.kills.totalKills,
                    TotalAssits = champ.data.stat.kills.totalAssists,
                    TotalWins = champ.data.totalWins,
                    LargestCritStrike = champ.data.stat.damage.mostCriticalStrikeDamage,
                    Name = key.Value.name,
                    ImageUrl = "http://ddragon.leagueoflegends.com/cdn/5.7.2/img/champion/" + key.Value.key + ".png",
                });
            }
            return champions.OrderByDescending(c =>c.Kills).ToList();
        }

        public JsonResult GetChampionData(int id)
        {
            var champData = Data.champions.FirstOrDefault(c => c.championId == id);
            var key = ChampionKeys.FirstOrDefault(c => c.Value.id == id);
            var model = new ChampionData
            {
                Id = champData.championId,
                Kills =champData.data.stat.kills.totalKills / champData.data.timesPicked,
                Deaths= champData.data.stat.kills.totalDeaths/ champData.data.timesPicked,
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

            return Json(
                new
                {
                    data = RenderPartialViewToString("Partials/_ChampionDetails", model)
                }, JsonRequestBehavior.AllowGet);
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
            return faction;
        }

        public ActionResult Map()
        {
            return View();
        }
    }
}