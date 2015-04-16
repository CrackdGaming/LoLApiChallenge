using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using LoLApiChallenge.Models;
using Newtonsoft.Json;

namespace LoLApiChallenge.Controllers
{
    public class BaseController : Controller
    {
        public static int[] Bilgewater = { 105, 41, 104, 21, 111, 4 };
        public static int[] BandleCity = { 32, 42, 74, 85, 117, 78, 68, 17, 18, 45, 115 };
        public static int[] BlackRose = { 7, 50, 60, 8 };
        public static int[] Demacia = { 114, 3, 86, 59, 10, 99, 78, 133, 102, 37, 44, 67, 5, 236 };
        public static int[] Freljord = { 34, 22, 79, 127, 20, 2, 113, 48, 23, 77, 106 };
        public static int[] Ionia = { 103, 84, 39, 24, 43, 85, 64, 11, 98, 37, 16, 134, 77, 110, 62, 5, 238 };
        public static int[] Independant = { 266, 12, 1, 63, 9, 40, 54, 57, 267, 76, 56, 107, 13, 35, 72, 143 };
        public static int[] MtTargon = { 131, 89, 80 };
        public static int[] Noxus = { 69, 122, 119, 55, 7, 25, 92, 14, 50, 91, 6, 8 };
        public static int[] Piltover = { 51, 42, 81, 74, 126, 61, 254, 26 };
        public static int[] Shurima = { 69, 75, 33, 58, 15, 101 };
        public static int[] ShadowIsles = { 60, 28, 120, 30, 82, 412, 83 };
        public static int[] TheVoid = { 31, 38, 121, 96, 90 };
        public static int[] Zaun = { 53, 36, 27, 29, 6, 112, 19, 154 };
        public readonly string ApiKey = WebConfigurationManager.AppSettings["ApiKey"];

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
        public virtual string RenderPartialViewToString()
        {
            return RenderPartialViewToString(null, null);
        }

        /// <summary>
        /// Render partial view to string
        /// </summary>
        /// <param name="viewName">View name</param>
        /// <returns>Result</returns>
        public virtual string RenderPartialViewToString(string viewName)
        {
            return RenderPartialViewToString(viewName, null);
        }
        /// <summary>
        /// Render partial view to string
        /// </summary>
        /// <param name="model">Model</param>
        /// <returns>Result</returns>
        public virtual string RenderPartialViewToString(object model)
        {
            return RenderPartialViewToString(null, model);
        }
        /// <summary>
        /// Render partial view to string
        /// </summary>
        /// <param name="viewName">View name</param>
        /// <param name="model">Model</param>
        /// <returns>Result</returns>
        public virtual string RenderPartialViewToString(string viewName, object model)
        {
            //Original source code: http://craftycodeblog.com/2010/05/15/asp-net-mvc-render-partial-view-to-string/
            if (string.IsNullOrEmpty(viewName))
                viewName = this.ControllerContext.RouteData.GetRequiredString("action");

            this.ViewData.Model = model;

            using (var sw = new StringWriter())
            {
                ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(this.ControllerContext, viewName);
                var viewContext = new ViewContext(this.ControllerContext, viewResult.View, this.ViewData, this.TempData, sw);
                viewResult.View.Render(viewContext, sw);

                return sw.GetStringBuilder().ToString();
            }
        }
    }
}