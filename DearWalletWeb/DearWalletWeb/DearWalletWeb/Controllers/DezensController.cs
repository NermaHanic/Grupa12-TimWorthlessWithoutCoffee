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
    public class DezensController : Controller
    {
        private DearWalletContext db = new DearWalletContext();

        // GET: Dezens
        public ActionResult Index()
        {
            return View(db.Dezen.ToList());
        }

        // GET: Dezens/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dezen dezen = db.Dezen.Find(id);
            if (dezen == null)
            {
                return HttpNotFound();
            }
            return View(dezen);
        }

        // GET: Dezens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dezens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NazivDezena,SlikaDezena,CijenaDezena")] Dezen dezen)
        {
            if (ModelState.IsValid)
            {
                db.Dezen.Add(dezen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dezen);
        }

        // GET: Dezens/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dezen dezen = db.Dezen.Find(id);
            if (dezen == null)
            {
                return HttpNotFound();
            }
            return View(dezen);
        }

        // POST: Dezens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NazivDezena,SlikaDezena,CijenaDezena")] Dezen dezen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dezen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dezen);
        }

        // GET: Dezens/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dezen dezen = db.Dezen.Find(id);
            if (dezen == null)
            {
                return HttpNotFound();
            }
            return View(dezen);
        }

        // POST: Dezens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Dezen dezen = db.Dezen.Find(id);
            db.Dezen.Remove(dezen);
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
