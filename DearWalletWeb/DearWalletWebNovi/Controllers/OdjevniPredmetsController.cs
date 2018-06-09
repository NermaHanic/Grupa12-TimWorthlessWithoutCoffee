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
    public class OdjevniPredmetsController : Controller
    {
        private DressMeUpContext db = new DressMeUpContext();

        // GET: OdjevniPredmets
        public ActionResult Index()
        {
            return View(db.OdjevniPredmet.ToList());
        }

        // GET: OdjevniPredmets/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OdjevniPredmet odjevniPredmet = db.OdjevniPredmet.Find(id);
            if (odjevniPredmet == null)
            {
                return HttpNotFound();
            }
            return View(odjevniPredmet);
        }

        // GET: OdjevniPredmets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OdjevniPredmets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Naziv,Slika,PSlika,Cijena")] OdjevniPredmet odjevniPredmet)
        {
            if (ModelState.IsValid)
            {
                db.OdjevniPredmet.Add(odjevniPredmet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(odjevniPredmet);
        }

        // GET: OdjevniPredmets/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OdjevniPredmet odjevniPredmet = db.OdjevniPredmet.Find(id);
            if (odjevniPredmet == null)
            {
                return HttpNotFound();
            }
            return View(odjevniPredmet);
        }

        // POST: OdjevniPredmets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Naziv,Slika,PSlika,Cijena")] OdjevniPredmet odjevniPredmet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(odjevniPredmet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(odjevniPredmet);
        }

        // GET: OdjevniPredmets/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OdjevniPredmet odjevniPredmet = db.OdjevniPredmet.Find(id);
            if (odjevniPredmet == null)
            {
                return HttpNotFound();
            }
            return View(odjevniPredmet);
        }

        // POST: OdjevniPredmets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            OdjevniPredmet odjevniPredmet = db.OdjevniPredmet.Find(id);
            db.OdjevniPredmet.Remove(odjevniPredmet);
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
