using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod09_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/SelectorDemo
        public ActionResult SelectorDemo()
        {
            return View();
        }

        public ActionResult JsonData(string id,string name)
        {
            if (Request.IsAjaxRequest())
            {
                var data = new { empId = id, EmpName = name, age = DateTime.Now.Millisecond };
                return Json(data);
                //return Json(data, JsonRequestBehavior.AllowGet);
            }
            else {
                return View();
            }
        }

    }
}