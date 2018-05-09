using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mod02_01.Models;
using Mod02_01.DAL;
using System.Net;
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



        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new  HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Opera o = context.Operas.FirstOrDefault(m => m.OperaID == id);

            if (o == null)
            {
                return HttpNotFound();
            }

            return View(o);
        }


    }
}