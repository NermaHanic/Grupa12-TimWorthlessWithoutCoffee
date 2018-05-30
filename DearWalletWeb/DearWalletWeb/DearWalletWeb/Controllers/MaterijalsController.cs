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
    public class MaterijalsController : Controller
    {
        private DearWalletContext db = new DearWalletContext();

        // GET: Materijals
        public ActionResult Index()
        {
            return View(db.Materijal.ToList());
        }

        // GET: Materijals/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materijal materijal = db.Materijal.Find(id);
            if (materijal == null)
            {
                return HttpNotFound();
            }
            return View(materijal);
        }

        // GET: Materijals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Materijals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaterijalId,NazivMaterijala,CijenaMaterijala")] Materijal materijal)
        {
            if (ModelState.IsValid)
            {
                db.Materijal.Add(materijal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(materijal);
        }

        // GET: Materijals/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materijal materijal = db.Materijal.Find(id);
            if (materijal == null)
            {
                return HttpNotFound();
            }
            return View(materijal);
        }

        // POST: Materijals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaterijalId,NazivMaterijala,CijenaMaterijala")] Materijal materijal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(materijal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(materijal);
        }

        // GET: Materijals/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materijal materijal = db.Materijal.Find(id);
            if (materijal == null)
            {
                return HttpNotFound();
            }
            return View(materijal);
        }

        // POST: Materijals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Materijal materijal = db.Materijal.Find(id);
            db.Materijal.Remove(materijal);
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
