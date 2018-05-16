using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mod04_09.Models;

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
            ProductSystem p = new ProductSystem();
            var result = p.GetProductByID(id);

            return View(result);
        }

        // GET: Home/ProductByCategory/1
        // GET: Home/ProductByCategory?id=1
        public ActionResult ProductByCategory(int id)
        {

            ProductSystem p = new ProductSystem();
            var result = p.GetProductsByCategryID(id);

            return View(result);
        }
    }
}