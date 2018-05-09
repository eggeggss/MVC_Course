using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod03_02.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["date1"] = DateTime.Now;
            ViewBag.date2 = DateTime.Now;

            return View();
        }
    }
}