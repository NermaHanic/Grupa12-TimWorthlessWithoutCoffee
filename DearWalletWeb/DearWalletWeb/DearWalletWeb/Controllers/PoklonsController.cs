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
    public class PoklonsController : Controller
    {
        private DearWalletContext db = new DearWalletContext();

        // GET: Poklons
        public ActionResult Index()
        {
            var poklons = db.Poklons.Include(p => p.Narudzba);
            return View(poklons.ToList());
        }

        // GET: Poklons/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Poklon poklon = db.Poklons.Find(id);
            if (poklon == null)
            {
                return HttpNotFound();
            }
            return View(poklon);
        }

        // GET: Poklons/Create
        public ActionResult Create()
        {
            ViewBag.NarudzbaId = new SelectList(db.Narudzba, "NarudzbaId", "DostavaId");
            return View();
        }

        // POST: Poklons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NarudzbaId,TekstPoruke,Snimak")] Poklon poklon)
        {
            if (ModelState.IsValid)
            {
                db.Poklons.Add(poklon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NarudzbaId = new SelectList(db.Narudzba, "NarudzbaId", "DostavaId", poklon.NarudzbaId);
            return View(poklon);
        }

        // GET: Poklons/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Poklon poklon = db.Poklons.Find(id);
            if (poklon == null)
            {
                return HttpNotFound();
            }
            ViewBag.NarudzbaId = new SelectList(db.Narudzba, "NarudzbaId", "DostavaId", poklon.NarudzbaId);
            return View(poklon);
        }

        // POST: Poklons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NarudzbaId,TekstPoruke,Snimak")] Poklon poklon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(poklon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NarudzbaId = new SelectList(db.Narudzba, "NarudzbaId", "DostavaId", poklon.NarudzbaId);
            return View(poklon);
        }

        // GET: Poklons/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Poklon poklon = db.Poklons.Find(id);
            if (poklon == null)
            {
                return HttpNotFound();
            }
            return View(poklon);
        }

        // POST: Poklons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Poklon poklon = db.Poklons.Find(id);
            db.Poklons.Remove(poklon);
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
