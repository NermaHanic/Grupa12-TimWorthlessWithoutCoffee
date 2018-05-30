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
    public class MjerasController : Controller
    {
        private DearWalletContext db = new DearWalletContext();

        // GET: Mjeras
        public ActionResult Index()
        {
            return View(db.Mjera.ToList());
        }

        // GET: Mjeras/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mjera mjera = db.Mjera.Find(id);
            if (mjera == null)
            {
                return HttpNotFound();
            }
            return View(mjera);
        }

        // GET: Mjeras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mjeras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MjeraId,DuzinaRuke,DuzinaNoge,ObimStruka,ObimGrudi,SirinaRamena")] Mjera mjera)
        {
            if (ModelState.IsValid)
            {
                db.Mjera.Add(mjera);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mjera);
        }

        // GET: Mjeras/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mjera mjera = db.Mjera.Find(id);
            if (mjera == null)
            {
                return HttpNotFound();
            }
            return View(mjera);
        }

        // POST: Mjeras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MjeraId,DuzinaRuke,DuzinaNoge,ObimStruka,ObimGrudi,SirinaRamena")] Mjera mjera)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mjera).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mjera);
        }

        // GET: Mjeras/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mjera mjera = db.Mjera.Find(id);
            if (mjera == null)
            {
                return HttpNotFound();
            }
            return View(mjera);
        }

        // POST: Mjeras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Mjera mjera = db.Mjera.Find(id);
            db.Mjera.Remove(mjera);
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
