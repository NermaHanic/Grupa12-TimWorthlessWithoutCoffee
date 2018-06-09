using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DearWalletWebNovi.Models;

namespace DearWalletWebNovi.Controllers
{
    public class KreacijasController : Controller
    {
        private DressMeUpContext db = new DressMeUpContext();

        // GET: Kreacijas
        public ActionResult Index()
        {
            return View(db.Kreacija.ToList());
        }

        // GET: Kreacijas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kreacija kreacija = db.Kreacija.Find(id);
            if (kreacija == null)
            {
                return HttpNotFound();
            }
            return View(kreacija);
        }

        // GET: Kreacijas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kreacijas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdDezen,Boja,IdOdjevniPredmet,IdKorisnika,Velicina")] Kreacija kreacija)
        {
            if (ModelState.IsValid)
            {
                db.Kreacija.Add(kreacija);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kreacija);
        }

        // GET: Kreacijas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kreacija kreacija = db.Kreacija.Find(id);
            if (kreacija == null)
            {
                return HttpNotFound();
            }
            return View(kreacija);
        }

        // POST: Kreacijas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdDezen,Boja,IdOdjevniPredmet,IdKorisnika,Velicina")] Kreacija kreacija)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kreacija).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kreacija);
        }

        // GET: Kreacijas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kreacija kreacija = db.Kreacija.Find(id);
            if (kreacija == null)
            {
                return HttpNotFound();
            }
            return View(kreacija);
        }

        // POST: Kreacijas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Kreacija kreacija = db.Kreacija.Find(id);
            db.Kreacija.Remove(kreacija);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
