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
    public class OdgovorsController : Controller
    {
        private NewContext db = new NewContext();

        // GET: Odgovors
        public ActionResult Index()
        {
            var odgovor = db.Odgovor.Include(o => o.Pitanje);
            return View(odgovor.ToList());
        }

        // GET: Odgovors/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odgovor odgovor = db.Odgovor.Find(id);
            if (odgovor == null)
            {
                return HttpNotFound();
            }
            return View(odgovor);
        }

        // GET: Odgovors/Create
        public ActionResult Create()
        {
            ViewBag.PitanjeId = new SelectList(db.Pitanje, "PitanjeId", "Tekst");
            return View();
        }

        // POST: Odgovors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OdgovorId,PitanjeId,TekstOdgovora,PripadniStil")] Odgovor odgovor)
        {
            if (ModelState.IsValid)
            {
                db.Odgovor.Add(odgovor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PitanjeId = new SelectList(db.Pitanje, "PitanjeId", "Tekst", odgovor.PitanjeId);
            return View(odgovor);
        }

        // GET: Odgovors/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odgovor odgovor = db.Odgovor.Find(id);
            if (odgovor == null)
            {
                return HttpNotFound();
            }
            ViewBag.PitanjeId = new SelectList(db.Pitanje, "PitanjeId", "Tekst", odgovor.PitanjeId);
            return View(odgovor);
        }

        // POST: Odgovors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OdgovorId,PitanjeId,TekstOdgovora,PripadniStil")] Odgovor odgovor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(odgovor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PitanjeId = new SelectList(db.Pitanje, "PitanjeId", "Tekst", odgovor.PitanjeId);
            return View(odgovor);
        }

        // GET: Odgovors/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odgovor odgovor = db.Odgovor.Find(id);
            if (odgovor == null)
            {
                return HttpNotFound();
            }
            return View(odgovor);
        }

        // POST: Odgovors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Odgovor odgovor = db.Odgovor.Find(id);
            db.Odgovor.Remove(odgovor);
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
