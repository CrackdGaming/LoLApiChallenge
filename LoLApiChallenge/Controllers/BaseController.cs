using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        public int[] Bilgewater = { 105, 41, 104, 21, 111, 4 };
        public int[] BandleCity = { 32, 42, 74, 85, 117, 78, 68, 17, 18, 45, 115};
        public int[] BlackRose = { 7, 50,60, 8};
        public int[] Demacia = { 114, 3, 86, 59, 10, 99, 78, 133, 102, 37, 44, 67, 5, 236 };
        public int[] Freljord = { 34, 22, 79, 127, 20, 2, 113, 48, 23, 77, 106};
        public int[] Ionia = { 103, 84, 39, 24, 43, 85, 64, 11, 98, 37, 16, 134, 77, 110, 62, 5, 238};
        public int[] Independant = { 266, 12, 1, 63, 9, 40, 54, 57, 267, 76, 56, 107,13,35, 72, 143};
        public int[] MtTargon = { 131, 89, 80};
        public int[] Noxus = { 69, 122, 119, 55, 7, 25, 92, 14, 50, 91, 6, 8};
        public int[] Piltover = { 51, 42, 81, 74, 126, 61, 254, 26};
        public int[] Shurima = { 69, 75, 33, 58, 15, 101};
        public int[] ShadowIsles = { 60, 28, 120, 30, 82, 412, 83};
        public int[] TheVoid = { 31, 38, 121, 96, 90};
        public int[] Zaun = { 53, 36, 27, 29, 6, 112, 19, 154};
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