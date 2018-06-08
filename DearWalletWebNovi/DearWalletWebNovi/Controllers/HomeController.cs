using DearWalletWebNovi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DearWalletWebNovi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Index(string usernameLogin, string passwordLogin)
        {
            DearWalletContext db = new DearWalletContext();
            List<Korisnik> listaKorisnika = db.Korisnik.ToList();
            for (int i = 0; i < listaKorisnika.Count; i++)
            {
                if (listaKorisnika[i].Username.Equals(usernameLogin))
                {

                    if (passwordLogin.Equals(listaKorisnika[i].Sifra))
                    {
                        Session["User"] = listaKorisnika[i];
                        Session["UserId"] = listaKorisnika[i].Id;
                        return RedirectToAction("Index", "Korisniks"); //prebacuje na homepage za korisnika
                    }
                    else
                    {
                        ViewBag.passwordGreska = "Pogresna sifra!";
                        return View();
                    }

                }
            }
            return Content($"{usernameLogin} {passwordLogin}, Vi nemate profil :(");

        }
    }
}
