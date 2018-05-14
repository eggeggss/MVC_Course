using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mod02_01.Models;
using Mod02_01.DAL;
using System.Net;
using System.Data.Entity;

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


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Operas.Add(opera);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(opera);
            
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Opera o = context.Operas.FirstOrDefault(m => m.OperaID == id);

            if (o == null)
            {
                return HttpNotFound();
            }

            return View(o);
        }


        [HttpPost]
        public ActionResult Edit(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Entry(opera).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(opera);

        }
        /*
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Opera o = context.Operas.FirstOrDefault(m => m.OperaID == id);

            if (o == null)
            {
                return HttpNotFound();
            }

            return View(o);
        }

        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Entry(opera).State = EntityState.Deleted;
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(opera);

        }*/

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Opera o = context.Operas.FirstOrDefault(m => m.OperaID == id);

            if (o == null)
            {
                return HttpNotFound();
            }

            var opera=context.Operas.Find(id);

            context.Operas.Remove(o);
            context.SaveChanges();


            return View("Index");
        }

    }
}