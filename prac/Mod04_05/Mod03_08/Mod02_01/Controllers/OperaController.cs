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

        //建立DB物件
        private OperaContext context = new OperaContext();

        // GET: Opera
        // GET: Opera/Index
        public ActionResult Index()
        {
            return View(context.Operas.ToList());
        }

        public ActionResult Filterdata(int number)
        {
            var result=context.Operas.OrderByDescending(m => m.Year).Take(number).ToList();
            return View("Index", result);
        }

        // GET: Opera/Details/1
        // GET: Opera/Details?id=1
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Opera o = context.Operas.Find(id);

            if (o == null)
                return HttpNotFound();

            return View(o);
        }

        // GET: Opera/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Opera/Create
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

        // GET: Opera/Edit/1
        // GET: Opera/Edit?id=1
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Opera o = context.Operas.Find(id);
            if (o == null)
            {
                return HttpNotFound();
            }
            return View(o);
        }

        // POST: Opera/Edit
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

        // GET: Opera/Delete/1
        // GET: Opera/Delete?id=1
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

        //    Opera o = context.Operas.Find(id);
        //    if (o == null)
        //        return HttpNotFound();

        //    return View(o);
        //}

        // POST: Opera/Delete/1
        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int? id)
        //{
        //    Opera o = context.Operas.Find(id);
        //    context.Operas.Remove(o);
        //    context.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        // GET: Opera/Delete/1
        // GET: Opera/Delete?id=1
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Opera o = context.Operas.Find(id);
            if (o == null)
                return HttpNotFound();
            context.Operas.Remove(o);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}