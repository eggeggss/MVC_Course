using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod11_01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult SessionDemo()
        {
            if (Session["count"] == null)
            {
                Session["count"] = 0;
            }
            else
            {
                Session["count"] = ((int)Session["count"])+1;
            }

            return View();
        }

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.date1 = DateTime.Now;
            ViewData["date2"] = DateTime.Now;
            TempData["date3"] = DateTime.Now;
            return RedirectToAction("TempDemp");
            //return View();
        }

        public ActionResult TempDemp()
        {
            return View();
        }
    }
}