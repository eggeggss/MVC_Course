using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mod04_09.DAL;

namespace Mod04_09.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/ProductByID/1
        // GET: Home/ProductByID?id=1
        public ActionResult ProductByID(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            //var query = from p in db.Products
            //            where p.ProductID == id
            //            select p;
            var result = db.Products.Find(id);

            return View(result);
        }

        // GET: Home/ProductByCategory/1
        // GET: Home/ProductByCategory?id=1
        public ActionResult ProductByCategory(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.CategoryID == id
                        select p;
            var result = query.ToList();

            return View(result);
        }
    }
}