using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoLApiChallenge.Models;

namespace LoLApiChallenge.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var model = new UrfDataModel{FullData = Data};
            return View(model);
        }

        public ActionResult Map()
        {
            return View();
        }
    }
}