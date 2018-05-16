using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.dal;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult ProductById(int? id)
        {
            NorthwindEntities entity = new NorthwindEntities();
            return View( entity.Products.Find(id));
        }

        public ActionResult ProductByCategory(int? id)
        {
            NorthwindEntities entity = new NorthwindEntities();
            return View(entity.Categories.Find(id));
        }

        [HandleError]
        public ActionResult Index()
        {

            int i = 0;
            int j = 10 / i;
            //throw new Exception($"something wrong");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}