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
            var facIndependant = new FactionData
            {
                Name = "Independant"
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
                if (Independant.Contains(champ.championId))
                {
                    facIndependant = AddTotals(champ.data.timesPicked, champ.data.stat.kills.totalKills,
                        champ.data.stat.kills.totalAssists, champ.data.stat.kills.totalDeaths, facIndependant);
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
            facIndependant = AverageData(facIndependant);
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
            model.Factions.Add(facIndependant);
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
            switch (id)
            {
                case "Bilgewater" :
                    foreach (var i in Bilgewater)
                    {
                        model.Champs.Add(PopulateChampData(i));
                    }
                    break;
                case "Bandle City" :
                    foreach (var i in BandleCity)
                    {
                        model.Champs.Add(PopulateChampData(i));
                    }
                    break;
                case "Black Rose":
                    foreach (var i in BlackRose)
                    {
                        model.Champs.Add(PopulateChampData(i));
                    }
                    break;
                case "Demacia":
                    foreach (var i in Demacia)
                    {
                        model.Champs.Add(PopulateChampData(i));
                    }
                    break;
                case "Freljord":
                    foreach (var i in Freljord)
                    {
                        model.Champs.Add(PopulateChampData(i));
                    }
                    break;
                case "Ionia":
                    foreach (var i in Ionia)
                    {
                        model.Champs.Add(PopulateChampData(i));
                    }
                    break;
                case "Independant":
                    foreach (var i in Independant)
                    {
                        model.Champs.Add(PopulateChampData(i));
                    }
                    break;
                case "Mount Targon":
                    foreach (var i in MtTargon)
                    {
                        model.Champs.Add(PopulateChampData(i));
                    }
                    break;
                case "Noxus":
                    foreach (var i in Noxus)
                    {
                        model.Champs.Add(PopulateChampData(i));
                    }
                    break;
                case "Piltover":
                    foreach (var i in Piltover)
                    {
                        model.Champs.Add(PopulateChampData(i));
                    }
                    break;
                case "Shurimas Desert":
                    foreach (var i in Shurima)
                    {
                        model.Champs.Add(PopulateChampData(i));
                    }
                    break;
                case "Shadow Isles":
                    foreach (var i in ShadowIsles)
                    {
                        model.Champs.Add(PopulateChampData(i));
                    }
                    break;
                case "The Void":
                    foreach (var i in TheVoid)
                    {
                        model.Champs.Add(PopulateChampData(i));
                    }
                    break;
                case "Zaun":
                    foreach (var i in Zaun)
                    {
                        model.Champs.Add(PopulateChampData(i));
                    }
                    break;
            }
            return Json(
                new
                {
                    data = RenderPartialViewToString("Partials/_FactionDetails", model)
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
            return faction;
        }

        public ActionResult Map()
        {
            return View();
        }
    }
}