using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pratica2.Controllers
{
    public class ParetoController : Controller
    {
        // GET: Pareto
        public ActionResult Index()
        {
            ViewBag.Titile = "Pareto";
            return View();
        }
    }
}