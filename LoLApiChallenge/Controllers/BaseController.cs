using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoLApiChallenge.Models;
using Newtonsoft.Json;

namespace LoLApiChallenge.Controllers
{
    public class BaseController : Controller
    {
        public int[] Demacia = {114,};
        public int[] Noxus { get; set; }
        public int[] Ionia { get; set; }
        public int[] Piltover { get; set; }
        public int[] BandleCity { get; set; }
        public int[] Freljord { get; set; }
        public int[] TheVoid { get; set; }
        public int[] Shurima { get; set; }
        public int[] MtTargon { get; set; }
        public int[] ShadowIsles { get; set; }
        public int[] Bilgewater { get; set; }
        public int[] Independant { get; set; }
        private static RootObject _data;
        public RootObject Data {
            get
            {
                if (_data != null) return _data;
                using (StreamReader r =new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\Content\snapshot.json"))
                {
                    string json = r.ReadToEnd();
                    _data = JsonConvert.DeserializeObject<RootObject>(json);
                }
                return _data;
            }
        }
    }
}