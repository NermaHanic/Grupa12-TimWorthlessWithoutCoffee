using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DearWalletWebNovi.Models;

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
            DressMeUpContext db = new DressMeUpContext();
            List<Korisnik> listaKorisnika = db.Korisnik.ToList();
            for (int i = 0; i < listaKorisnika.Count; i++)
            {
                if (listaKorisnika[i].Username.Equals(usernameLogin))
                {

                    if (passwordLogin.Equals(listaKorisnika[i].Sifra))
                    {
                        Session["User"] = listaKorisnika[i];
                        Session["UserId"] = listaKorisnika[i].Id;
                        return RedirectToAction("Index", "Korisniks");
                    }
                    else
                    {
                        ViewBag.passwordGreska = "Password nije ispravan!";
                        return View();
                    }

                }
            }
            return Content($"Niste registrovani, {usernameLogin} {passwordLogin}!");

        }
    }
}