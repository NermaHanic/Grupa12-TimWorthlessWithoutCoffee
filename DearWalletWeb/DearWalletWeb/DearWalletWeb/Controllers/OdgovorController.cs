using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DearWalletWeb;
using DearWalletWeb.Models;

namespace DearWalletWeb.Controllers
{
    public class OdgovorController : Controller
    {
        private DearWalletContext db = new DearWalletContext();

        // GET: Odgovor
        public ActionResult Index()
        {
            var Odgovor = db.Odgovor.Include(o => o.Pitanje);
            return View(Odgovor.ToList());
        }

        // GET: Odgovor/Details/5
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

        // GET: Odgovor/Create
        public ActionResult Create()
        {
            ViewBag.PitanjeId = new SelectList(db.Pitanjes, "PitanjeId", "Tekst");
            return View();
        }

        // POST: Odgovor/Create
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

            ViewBag.PitanjeId = new SelectList(db.Pitanjes, "PitanjeId", "Tekst", odgovor.PitanjeId);
            return View(odgovor);
        }

        // GET: Odgovor/Edit/5
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
            ViewBag.PitanjeId = new SelectList(db.Pitanjes, "PitanjeId", "Tekst", odgovor.PitanjeId);
            return View(odgovor);
        }

        // POST: Odgovor/Edit/5
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
            ViewBag.PitanjeId = new SelectList(db.Pitanjes, "PitanjeId", "Tekst", odgovor.PitanjeId);
            return View(odgovor);
        }

        // GET: Odgovor/Delete/5
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

        // POST: Odgovor/Delete/5
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
