using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWebNovi.Models
{
    public static class Helper
    {
        public static string DodjelaIdKorisnik()
        {
            DressMeUpContext db = new DressMeUpContext();
            return (db.Korisnik.ToList().Count() + 1).ToString();
        }
        public static string DodjelaIdDezen()
        {
            DressMeUpContext db = new DressMeUpContext();
            return (db.Dezen.ToList().Count() + 1).ToString();
        }
        public static string DodjelaIdOdjevniPredmet()
        {
            DressMeUpContext db = new DressMeUpContext();
            return (db.OdjevniPredmet.ToList().Count() + 1).ToString();
        }
        public static string DodjelaIdKreacija()
        {
            DressMeUpContext db = new DressMeUpContext();
            return (db.Kreacija.ToList().Count() + 1).ToString();
        }

    }
}