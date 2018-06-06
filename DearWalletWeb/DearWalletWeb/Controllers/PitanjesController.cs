using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DearWalletWeb.Models;

namespace DearWalletWeb.Controllers
{
    public class PitanjesController : Controller
    {
        private NewContext db = new NewContext();

        // GET: Pitanjes
        public ActionResult Index()
        {
            return View(db.Pitanje.ToList());
        }

        // GET: Pitanjes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pitanje pitanje = db.Pitanje.Find(id);
            if (pitanje == null)
            {
                return HttpNotFound();
            }
            return View(pitanje);
        }

        // GET: Pitanjes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pitanjes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PitanjeId,Tekst")] Pitanje pitanje)
        {
            if (ModelState.IsValid)
            {
                db.Pitanje.Add(pitanje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pitanje);
        }

        // GET: Pitanjes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pitanje pitanje = db.Pitanje.Find(id);
            if (pitanje == null)
            {
                return HttpNotFound();
            }
            return View(pitanje);
        }

        // POST: Pitanjes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PitanjeId,Tekst")] Pitanje pitanje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pitanje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pitanje);
        }

        // GET: Pitanjes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pitanje pitanje = db.Pitanje.Find(id);
            if (pitanje == null)
            {
                return HttpNotFound();
            }
            return View(pitanje);
        }

        // POST: Pitanjes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Pitanje pitanje = db.Pitanje.Find(id);
            db.Pitanje.Remove(pitanje);
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
