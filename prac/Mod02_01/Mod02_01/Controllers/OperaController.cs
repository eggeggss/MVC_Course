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
            Opera data = new Opera
            {
                Title = "title1",
                OperaID = 1,
                Year = 1600,
                Composer = "pally"

            };

            
            return View(data);
        }
    }
}