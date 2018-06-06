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
    public class NarudzbasController : Controller
    {
        private NewContext db = new NewContext();

        // GET: Narudzbas
        public ActionResult Index()
        {
            var narudzba = db.Narudzba.Include(n => n.Dostava).Include(n => n.Poklon);
            return View(narudzba.ToList());
        }

        // GET: Narudzbas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Narudzba narudzba = db.Narudzba.Find(id);
            if (narudzba == null)
            {
                return HttpNotFound();
            }
            return View(narudzba);
        }

        // GET: Narudzbas/Create
        public ActionResult Create()
        {
            ViewBag.DostavaId = new SelectList(db.Dostava, "Id", "AdresaDostave");
            ViewBag.NarudzbaId = new SelectList(db.Poklon, "NarudzbaId", "TekstPoruke");
            return View();
        }

        // POST: Narudzbas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NarudzbaId,DostavaId,UkupnaCijena")] Narudzba narudzba)
        {
            if (ModelState.IsValid)
            {
                db.Narudzba.Add(narudzba);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DostavaId = new SelectList(db.Dostava, "Id", "AdresaDostave", narudzba.DostavaId);
            ViewBag.NarudzbaId = new SelectList(db.Poklon, "NarudzbaId", "TekstPoruke", narudzba.NarudzbaId);
            return View(narudzba);
        }

        // GET: Narudzbas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Narudzba narudzba = db.Narudzba.Find(id);
            if (narudzba == null)
            {
                return HttpNotFound();
            }
            ViewBag.DostavaId = new SelectList(db.Dostava, "Id", "AdresaDostave", narudzba.DostavaId);
            ViewBag.NarudzbaId = new SelectList(db.Poklon, "NarudzbaId", "TekstPoruke", narudzba.NarudzbaId);
            return View(narudzba);
        }

        // POST: Narudzbas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NarudzbaId,DostavaId,UkupnaCijena")] Narudzba narudzba)
        {
            if (ModelState.IsValid)
            {
                db.Entry(narudzba).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DostavaId = new SelectList(db.Dostava, "Id", "AdresaDostave", narudzba.DostavaId);
            ViewBag.NarudzbaId = new SelectList(db.Poklon, "NarudzbaId", "TekstPoruke", narudzba.NarudzbaId);
            return View(narudzba);
        }

        // GET: Narudzbas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Narudzba narudzba = db.Narudzba.Find(id);
            if (narudzba == null)
            {
                return HttpNotFound();
            }
            return View(narudzba);
        }

        // POST: Narudzbas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Narudzba narudzba = db.Narudzba.Find(id);
            db.Narudzba.Remove(narudzba);
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
