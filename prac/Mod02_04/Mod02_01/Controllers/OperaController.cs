using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mod02_01.DAL;
using Mod02_01.Models;

namespace Mod02_01.Controllers
{

    public class OperaController : Controller
    {
        private OperaContext _operaContext;

        public OperaContext OperaContext
        {
            get
            {

                if (_operaContext == null)
                {
                    _operaContext = new OperaContext();
                }
                return _operaContext;
            }
        }
        // GET: Opera
        //Get:Opera/Index?year=1234
        //Get:Opera/Index?id=1&title=xxx&year=1234&composer=3456
        //http://localhost:57940/Opera/Index/1234?title=xxx&year=1234&composer=3456
        //http://localhost:57940/Opera/Index?OperaID=1234&Title=xxx&Year=1234&Composer=3456
        //public ActionResult Index(int? id,string title,int? year,string composer)
        public ActionResult Index()

        {
            /*
            Opera data = new Opera
            {
                Title = title,
                OperaID = id,
                Year = year,
                Composer = composer

            };
            */

            return View(OperaContext.Operas.ToList());
        }
    }
}