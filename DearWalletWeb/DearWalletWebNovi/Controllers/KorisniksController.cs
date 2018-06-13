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
        private DressMeUpContext db = new DressMeUpContext();

        // GET: Korisniks
        public ActionResult Index()
        {
            List<object> lista = new List<object>();
            List <Kreacija> listaKreacija = new List<Kreacija>();
            List<OdjevniPredmet> listaOdjece = new List<OdjevniPredmet>();
            List<Dezen> listaDezena = new List<Dezen>();
            List<Narudzba> listaNaruzdbi = new List<Narudzba>();
            List<Kreacija> listaNarucenih = new List<Kreacija>();
            foreach (Narudzba n in db.Narudzba.ToList())
            {
                if (n.IdKorisnika.ToString() == Session["UserId"].ToString())
                {
                    listaNaruzdbi.Add(n);
                }
            }
            foreach (Kreacija k in db.Kreacija.ToList())
            {
                if (k.IdKorisnika.ToString() == Session["UserId"].ToString())
                {
                    listaKreacija.Add(k);
                    listaOdjece.Add(db.OdjevniPredmet.ToList().Find(x => x.Id == k.IdOdjevniPredmet));
                    listaDezena.Add(db.Dezen.ToList().Find(x => x.Id == k.IdDezen));
                    foreach (Narudzba n in listaNaruzdbi)
                    {
                        if (n.Id == k.IdNarudzbe)
                        {
                            listaNarucenih.Add(k);
                        }
                    }
                }
            }
           
            lista.Add(listaKreacija);
            lista.Add(listaOdjece);
            lista.Add(listaDezena);
            lista.Add(listaNaruzdbi);
            lista.Add(listaNarucenih);
            return View(lista);
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
        public ActionResult Create([Bind(Include = "Id,Ime,Prezime,Username,Sifra,Email,Adresa,BrojTel,BrojKreditneKartice")] Korisnik korisnik)
        {
            if (ModelState.IsValid)
            {
                db.Korisnik.Add(korisnik);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
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
