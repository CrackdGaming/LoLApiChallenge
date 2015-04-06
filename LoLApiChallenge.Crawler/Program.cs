using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIDataModels;
using Newtonsoft.Json;

namespace LoLApiChallenge.Crawler
{
    class Program
    {
        //A Puma sumId: 21520492
        private static readonly string BaseUrl = System.Configuration.ConfigurationManager.AppSettings["BaseUrl"];
        private static readonly string ApiKey = System.Configuration.ConfigurationManager.AppSettings["APIKey"];
        private static readonly string StorageLocation = System.Configuration.ConfigurationManager.AppSettings["StorageLocation"];
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var beginDate = new DateTime(2015, 4, 1, 5, 25, 0, DateTimeKind.Utc);
                    var helper = new LoLApiGenerator(ApiKey, BaseUrl);
                    var history = helper.GetMatchHistory(Region.na, 21520492);
                    DateTime epoch = new DateTime(1970, 1, 1,0,0,0,DateTimeKind.Utc);
                    var test = beginDate.Subtract(epoch).TotalSeconds;
                    var games = helper.ApiChallenge(Region.na,(long)test);
                    foreach (var game in games)
                    {
                        try
                        {
                            var match = helper.GetMatchByMatchId(Region.na, game, true);
                            var json = JsonConvert.SerializeObject(match);
                            string n = string.Format("{0}", match.matchId);
                            string path = StorageLocation + n + @".json";
                            if(!File.Exists(path))
                                System.IO.File.WriteAllText(path, json);
                        }
                        catch
                        {
                        }
                    }
                }
                catch
                {
                }
                Thread.Sleep(60000);
            }
        }
        private static string CallRestMethod(string url)
        {
            var result = "";
            try
            {
                var webrequest = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "GET";
                //webrequest.ContentType = "application/x-www-form-urlencoded";
                webrequest.ContentType = "application/json";

                var webresponse = (HttpWebResponse)webrequest.GetResponse();
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
    }
}
