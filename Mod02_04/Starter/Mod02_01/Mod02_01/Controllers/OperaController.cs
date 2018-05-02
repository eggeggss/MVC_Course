using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mod02_01.Models;
using Mod02_01.DAL;
namespace Mod02_01.Controllers
{
    public class OperaController : Controller
    {
        // GET: Opera
        private OperaContext context = new OperaContext();
        public ActionResult Index()
        {

            return View(context.Operas.ToList());
        }



    }
}