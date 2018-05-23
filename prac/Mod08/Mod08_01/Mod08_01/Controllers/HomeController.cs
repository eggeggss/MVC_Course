using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod08_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Call()
        {
            ViewBag.Title = "台大遴委遭約談 北檢：依法辦理 盼勿混淆焦點";
            return PartialView("_Call");
        }


        public ActionResult Call2(int? id)
        {
            ViewBag.Title =id+ "--台大遴委遭約談 北檢：依法辦理 盼勿混淆焦點";
            return PartialView("_Call");
        }
    }
}