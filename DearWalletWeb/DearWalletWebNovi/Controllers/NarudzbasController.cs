using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DearWalletWebNovi.Models;

namespace DearWalletWebNovi.Controllers
{
    public class NarudzbasController : Controller
    {
        private DressMeUpContext db = new DressMeUpContext();

        // GET: Narudzbas
        public ActionResult Index()
        {
            return View(db.Narudzba.ToList());
        }

        // GET: Narudzbas/Details/5
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Session["NarudzbaId"] = id;
            Narudzba narudzba = db.Narudzba.Find(id);
            if (narudzba == null)
            {
                return HttpNotFound();
            }
            double cijena = narudzba.Cijena;
            return View(narudzba);
        }

        

        // GET: Narudzbas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Narudzbas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdKorisnika")] Narudzba narudzba)
        {
            if (ModelState.IsValid)
            {
                db.Narudzba.Add(narudzba);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(narudzba);
        }

        // GET: Narudzbas/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: Narudzbas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdKorisnika")] Narudzba narudzba)
        {
            if (ModelState.IsValid)
            {
                db.Entry(narudzba).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(narudzba);
        }

        // GET: Narudzbas/Delete/5
        public ActionResult Delete(int? id)
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
        public ActionResult DeleteConfirmed(int id)
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
        public ActionResult SaveRecords(Narudzba model)
        {
            try
            {
                Narudzba artikal = new Narudzba();
                artikal.Id = model.Id;
                artikal.Cijena = model.Cijena;
                artikal.IdKorisnika = model.IdKorisnika;
                

                db.Narudzba.Add(artikal);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Kupovina()
        {
            Korisnik kupac = db.Korisnik.Find(Session["UserId"]);
            Kreacija artikal = db.Kreacija.Find(Session["ArtikalId"]);
            Narudzba n = new Narudzba();
            n.Id = kupac.Id;
            n.Id = artikal.Id;
            db.Narudzba.Add(n);
            db.SaveChanges();
            ViewBag.novac = "Kupovina uspjesna";
            return RedirectToAction("Index");
        }
    }
}
