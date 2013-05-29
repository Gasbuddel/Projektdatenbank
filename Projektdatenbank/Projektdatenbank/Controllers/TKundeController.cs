using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projektdatenbank.Models;

namespace Projektdatenbank.Controllers
{ 
    public class TKundeController : Controller
    {
        private ProjektdatenbankContext db = new ProjektdatenbankContext();

        //
        // GET: /TKunde/

        public ViewResult Index()
        {
            return View(db.TKunde.ToList());
        }

        //
        // GET: /TKunde/Details/5

        public ViewResult Details(int id)
        {
            TKunde tkunde = db.TKunde.Find(id);
            return View(tkunde);
        }

        //
        // GET: /TKunde/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /TKunde/Create

        [HttpPost]
        public ActionResult Create(TKunde tkunde)
        {
            if (ModelState.IsValid)
            {
                db.TKunde.Add(tkunde);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(tkunde);
        }
        
        //
        // GET: /TKunde/Edit/5
 
        public ActionResult Edit(int id)
        {
            TKunde tkunde = db.TKunde.Find(id);
            return View(tkunde);
        }

        //
        // POST: /TKunde/Edit/5

        [HttpPost]
        public ActionResult Edit(TKunde tkunde)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tkunde).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tkunde);
        }

        //
        // GET: /TKunde/Delete/5
 
        public ActionResult Delete(int id)
        {
            TKunde tkunde = db.TKunde.Find(id);
            return View(tkunde);
        }

        //
        // POST: /TKunde/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            TKunde tkunde = db.TKunde.Find(id);
            db.TKunde.Remove(tkunde);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}