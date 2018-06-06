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
    public class KreacijasController : Controller
    {
        private NewContext db = new NewContext();

        // GET: Kreacijas
        public ActionResult Index()
        {
            var kreacija = db.Kreacija.Include(k => k.Dezen).Include(k => k.Mjera).Include(k => k.Narudzba).Include(k => k.OdjevniPredmet).Include(k => k.Profil);
            return View(kreacija.ToList());
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
            ViewBag.DezenId = new SelectList(db.Dezen, "Id", "NazivDezena");
            ViewBag.MjeraId = new SelectList(db.Mjera, "MjeraId", "MjeraId");
            ViewBag.NarudzbaId = new SelectList(db.Narudzba, "NarudzbaId", "DostavaId");
            ViewBag.OdjevniPredmetId = new SelectList(db.OdjevniPredmet, "OdjevniPredmetId", "NazivOdjevnogPredmeta");
            ViewBag.ProfilId = new SelectList(db.Profil, "Id", "Id");
            return View();
        }

        // POST: Kreacijas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KreacijaId,ProfilId,OdjevniPredmetId,DezenId,MjeraId,NarudzbaId,defVel,TrenutnaCijena")] Kreacija kreacija)
        {
            if (ModelState.IsValid)
            {
                db.Kreacija.Add(kreacija);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DezenId = new SelectList(db.Dezen, "Id", "NazivDezena", kreacija.DezenId);
            ViewBag.MjeraId = new SelectList(db.Mjera, "MjeraId", "MjeraId", kreacija.MjeraId);
            ViewBag.NarudzbaId = new SelectList(db.Narudzba, "NarudzbaId", "DostavaId", kreacija.NarudzbaId);
            ViewBag.OdjevniPredmetId = new SelectList(db.OdjevniPredmet, "OdjevniPredmetId", "NazivOdjevnogPredmeta", kreacija.OdjevniPredmetId);
            ViewBag.ProfilId = new SelectList(db.Profil, "Id", "Id", kreacija.ProfilId);
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
            ViewBag.DezenId = new SelectList(db.Dezen, "Id", "NazivDezena", kreacija.DezenId);
            ViewBag.MjeraId = new SelectList(db.Mjera, "MjeraId", "MjeraId", kreacija.MjeraId);
            ViewBag.NarudzbaId = new SelectList(db.Narudzba, "NarudzbaId", "DostavaId", kreacija.NarudzbaId);
            ViewBag.OdjevniPredmetId = new SelectList(db.OdjevniPredmet, "OdjevniPredmetId", "NazivOdjevnogPredmeta", kreacija.OdjevniPredmetId);
            ViewBag.ProfilId = new SelectList(db.Profil, "Id", "Id", kreacija.ProfilId);
            return View(kreacija);
        }

        // POST: Kreacijas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KreacijaId,ProfilId,OdjevniPredmetId,DezenId,MjeraId,NarudzbaId,defVel,TrenutnaCijena")] Kreacija kreacija)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kreacija).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DezenId = new SelectList(db.Dezen, "Id", "NazivDezena", kreacija.DezenId);
            ViewBag.MjeraId = new SelectList(db.Mjera, "MjeraId", "MjeraId", kreacija.MjeraId);
            ViewBag.NarudzbaId = new SelectList(db.Narudzba, "NarudzbaId", "DostavaId", kreacija.NarudzbaId);
            ViewBag.OdjevniPredmetId = new SelectList(db.OdjevniPredmet, "OdjevniPredmetId", "NazivOdjevnogPredmeta", kreacija.OdjevniPredmetId);
            ViewBag.ProfilId = new SelectList(db.Profil, "Id", "Id", kreacija.ProfilId);
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
