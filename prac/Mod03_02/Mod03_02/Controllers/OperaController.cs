using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod03_02.Controllers
{
    public class OperaController : Controller
    {
        // GET: Opera
        public ActionResult Index(int id,string title,string name,string composter)
        {
            ViewData["id"] = id;
            ViewData["title"]= title;
            return View();
        }
    }
}