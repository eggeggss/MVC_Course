using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mod02_01.Models;
namespace Mod02_01.Controllers
{
    public class OperaController : Controller
    {
        // GET: Opera
        public ActionResult Index()
        {
            Opera o = new Opera()
            {
                OperaID = 1,
                Title = "尤利迪西",
                Year = 1600,
                Composer = "佩里"
            };
            return View(o);

        }
    }
}