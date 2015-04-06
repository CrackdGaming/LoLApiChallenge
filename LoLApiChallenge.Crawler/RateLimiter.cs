using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLApiChallenge.Crawler
{
    public class RateLimiter
    {
        private static readonly string RatePerTenSecond = System.Configuration.ConfigurationManager.AppSettings["RateLimitPerTenSecond"];
        private static readonly string RatePerTenMinute = System.Configuration.ConfigurationManager.AppSettings["RateLimitPerTenMinute"];
        private DateTime CurrentTenSecond;
        private DateTime CurrentTenMinute;
        private int CurrentRequestCountSecond = 0;
        private int CurrentRequestCountMinute = 0;
        public bool ExecuteTask()
        {
            //while(CurrentRequestCountSecond >)
            return false;
        }
    }
}
