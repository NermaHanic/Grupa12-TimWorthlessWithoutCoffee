﻿using System;
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
    public class PitanjeController : Controller
    {
        private DearWalletContext db = new DearWalletContext();

        // GET: Pitanje
        public ActionResult Index()
        {
            return View(db.Pitanjes.ToList());
        }

        // GET: Pitanje/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pitanje pitanje = db.Pitanjes.Find(id);
            if (pitanje == null)
            {
                return HttpNotFound();
            }
            return View(pitanje);
        }

        // GET: Pitanje/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pitanje/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PitanjeId,Tekst")] Pitanje pitanje)
        {
            if (ModelState.IsValid)
            {
                db.Pitanjes.Add(pitanje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pitanje);
        }

        // GET: Pitanje/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pitanje pitanje = db.Pitanjes.Find(id);
            if (pitanje == null)
            {
                return HttpNotFound();
            }
            return View(pitanje);
        }

        // POST: Pitanje/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PitanjeId,Tekst")] Pitanje pitanje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pitanje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pitanje);
        }

        // GET: Pitanje/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pitanje pitanje = db.Pitanjes.Find(id);
            if (pitanje == null)
            {
                return HttpNotFound();
            }
            return View(pitanje);
        }

        // POST: Pitanje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Pitanje pitanje = db.Pitanjes.Find(id);
            db.Pitanjes.Remove(pitanje);
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
