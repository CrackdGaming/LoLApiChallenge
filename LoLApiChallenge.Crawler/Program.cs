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
using NLog;


namespace LoLApiChallenge.Crawler
{
    class Program
    {
        //A Puma sumId: 21520492
        private static readonly string BaseUrl = System.Configuration.ConfigurationManager.AppSettings["BaseUrl"];
        private static readonly string ApiKey = System.Configuration.ConfigurationManager.AppSettings["ApiKey"];//"63baae19-8793-49f7-b895-37c0f0dfb2e1";//Environment.GetEnvironmentVariable("API_KEY");
        private static readonly string StorageLocation = System.Configuration.ConfigurationManager.AppSettings["StorageLocation"];
        private static readonly string StartDay = System.Configuration.ConfigurationManager.AppSettings["StartDay"];
        private static readonly string StartHour = System.Configuration.ConfigurationManager.AppSettings["StartHour"];
        private static readonly string StartMinute = System.Configuration.ConfigurationManager.AppSettings["StartMinute"];
        private static readonly string EndDay = System.Configuration.ConfigurationManager.AppSettings["EndDay"];
        private static readonly string EndHour = System.Configuration.ConfigurationManager.AppSettings["EndHour"];
        private static readonly string EndMinute = System.Configuration.ConfigurationManager.AppSettings["EndMinute"];
        static void Main(string[] args)
        {
            var logger = LogManager.GetLogger("Crawler");//LogManager.GetLogger("UserActionLogger");
            //var beginDate = new DateTime(2015, 4, 1, 5, 25, 0, DateTimeKind.Utc);
            int day = int.Parse(StartDay);
            int hour = int.Parse(StartHour);
            int minute = int.Parse(StartMinute);
            int endday = int.Parse(EndDay);
            int endhour = int.Parse(EndHour);
            int endminute = int.Parse(EndMinute);
            var beginDate = new DateTime(2015, 4, day, hour, minute, 0, DateTimeKind.Utc);
            var endDate = new DateTime(2015, 4, endday, endhour, endminute, 0, DateTimeKind.Utc);
            while (beginDate < endDate)
            {
                try
                {
                    logger.Info("Processing Date: " + beginDate.ToShortDateString() + " " + beginDate.ToShortTimeString());
                    var helper = new LoLApiGenerator(ApiKey, BaseUrl);
                    var history = helper.GetMatchHistory(Region.na, 21520492);
                    DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    var test = beginDate.Subtract(epoch).TotalSeconds;
                    var games = helper.ApiChallenge(Region.na, (long)test);
                    logger.Info("Number of Games: " + games.Count);
                    Thread.Sleep(1250);
                    foreach (var game in games)
                    {
                        try
                        {
                            var match = helper.GetMatchByMatchId(Region.na, game, true);
                            var json = JsonConvert.SerializeObject(match);
                            string n = string.Format("{0}", match.matchId);
                            string path = StorageLocation + n + @".json";
                            if (!File.Exists(path))
                                System.IO.File.WriteAllText(path, json);
                        }
                        catch (Exception ex)
                        {
                            logger.Debug("Error in date: " + beginDate.ToShortDateString() + " " + beginDate.ToShortTimeString());
                            logger.Error(ex.Message);
                        }
                        Thread.Sleep(1250);
                    }
                }
                catch (Exception ex)
                {
                    logger.Debug("Error in date: " + beginDate.ToShortDateString() + " " + beginDate.ToShortTimeString());
                    logger.Error(ex.Message);
                }
                beginDate = beginDate.AddMinutes(5);
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
