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
    public class KorisniksController : Controller
    {
        private DearWalletContext db = new DearWalletContext();

        // GET: Korisniks
        public ActionResult Index()
        {
            //listu kreacija
            //
            return View(db.Korisnik.ToList());
        }

        // GET: Korisniks/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return HttpNotFound();
            }
            return View(korisnik);
        }

        // GET: Korisniks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Korisniks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id, Ime,Prezime,Username,Sifra,Email,Adresa,BrojTel,BrojKreditneKartice")] Korisnik korisnik)
        {
            if (ModelState.IsValid)
            {
                //ne generise id for some reason
               // korisnik.Id = Helper.DodjelaIdKorisnik();
                db.Korisnik.Add(korisnik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(korisnik);
        }

        // GET: Korisniks/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return HttpNotFound();
            }
            return View(korisnik);
        }

        // POST: Korisniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ime,Prezime,Username,Sifra,Email,Adresa,BrojTel,BrojKreditneKartice")] Korisnik korisnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(korisnik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(korisnik);
        }

        // GET: Korisniks/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return HttpNotFound();
            }
            return View(korisnik);
        }

        // POST: Korisniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Korisnik korisnik = db.Korisnik.Find(id);
            db.Korisnik.Remove(korisnik);
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
