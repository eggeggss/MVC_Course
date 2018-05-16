using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod05_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/ExceptionDemo
        //[HandleError]
        //[HandleError(View = "aa")]
        //[HandleError(View = "~/Views/Shared/Error.cshtml")]
        public ActionResult ExceptionDemo()
        {
            int i = 0;
            int j = 10 / i;

            return View();
        }

    }
}