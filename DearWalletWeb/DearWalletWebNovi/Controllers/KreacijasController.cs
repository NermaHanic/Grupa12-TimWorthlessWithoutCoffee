using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DearWalletWebNovi.Models;
using Microsoft.AspNet.Identity;

namespace DearWalletWebNovi.Controllers
{
    public class KreacijasController : Controller
    {
        private DressMeUpContext db = new DressMeUpContext();

        // GET: Kreacijas/Create
        public ActionResult Create()
        {
            ViewBag.list1 = db.OdjevniPredmet.ToList();
            ViewBag.list2 = db.Dezen.ToList();
            return View();
        }

        public ActionResult OrderNow(int idKreacije)
        {
            Session["KreacijaId"] = idKreacije;
            Kreacija kr = db.Kreacija.Find(idKreacije);
            if (kr == null)
            {
                return HttpNotFound();
            }
            return View(kr);
        }
        [HttpPost]
        public ActionResult Create(Kreacija k)
        {
            //Dezen dezen = db.Dezen.Find(idD1);
            // ViewBag.isplata = db.Dezen;
            int idD1 =k.IdDezen;
            int idD2 =k.IdOdjevniPredmet;
            Dezen d = db.Dezen.ToList().Find(x => x.Id == idD1);
            OdjevniPredmet o = db.OdjevniPredmet.ToList().Find(x => x.Id == idD2);
            ViewBag.list1 = db.OdjevniPredmet.ToList();
            ViewBag.list2 = db.Dezen.ToList();
            var cijena = Convert.ToInt32(d.Cijena)+o.Cijena;
            ViewBag.cijena = "Cijena kreacije: " + cijena.ToString()+"KM";
            k.Cijena = Convert.ToInt32(cijena);
            k.IdKorisnika = Convert.ToInt32(Session["UserId"].ToString());
            db.Kreacija.Add(k);
            db.SaveChanges();
            return View();

        }

        [HttpPost]
       /* // GET: Kreacijas
        public ActionResult Create([Bind(Include = "Id,IdDezen,IdOdjevniPredmet,IdKorisnika,Velicina,Cijena")] Kreacija kreacija)
        {
            ViewBag.dezen = kreacija.IdDezen;
            db.Kreacija.Add(kreacija);
            db.SaveChanges();
            return View(kreacija);
        }*/
        
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
        



  

        // POST: Kreacijas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
       /* [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdDezen,IdOdjevniPredmet,IdKorisnika,Velicina,Cijena")] Kreacija kreacija)
        {
            ViewBag.user = User.Identity.GetUserId<int>();
            if (ModelState.IsValid)
            {
                db.Kreacija.Add(kreacija);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kreacija);
        }*/

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
            return View(kreacija);
        }

        // POST: Kreacijas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdDezen,IdOdjevniPredmet,IdKorisnika,Velicina")] Kreacija kreacija)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kreacija).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
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
