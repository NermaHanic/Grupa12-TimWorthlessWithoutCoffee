using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DearWalletWebNovi.Models
{
    public static class Helper
    {
        public static string DodjelaIdKorisnik()
        {
            DearWalletContext db = new DearWalletContext();
            return (db.Korisnik.ToList().Count() + 1).ToString();
        }
        public static string DodjelaIdDezen()
        {
            DearWalletContext db = new DearWalletContext();
            return (db.Dezen.ToList().Count() + 1).ToString();
        }
        public static string DodjelaIdOdjevniPredmet()
        {
            DearWalletContext db = new DearWalletContext();
            return (db.OdjevniPredmet.ToList().Count() + 1).ToString();
        }
        public static string DodjelaIdKreacija()
        {
            DearWalletContext db = new DearWalletContext();
            return (db.Kreacija.ToList().Count() + 1).ToString();
        }

    }
}