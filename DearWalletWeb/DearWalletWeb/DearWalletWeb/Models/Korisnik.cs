using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string BrojTel { get; set; }
        public string BrojKreditneKartice { get; set; }
        public string KorisnikId { get; set; }
        public string Sifra { get; set; }

        //public string ProfilId { get; set; }
        public virtual Profil Profil { get; set; }
    }
}