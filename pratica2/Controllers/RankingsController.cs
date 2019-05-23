using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pratica2.Controllers
{
    public class RankingsController : Controller
    {
        // GET: Rankings
        public ActionResult Index()
        {
            ViewBag.Title = "Ranking";
            return View();
        }
    }
}