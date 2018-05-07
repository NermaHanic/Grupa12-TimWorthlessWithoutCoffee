using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Korisnik
    {
        private string ime;
        private string prezime;
        private string email;
        private string adresa;
        private string brojTel;
        private string brojKreditneKartice;
        private string username;
        private string sifra;
        //povezivanje
        private Profil profil;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string BrojTel { get => brojTel; set => brojTel = value; }
        public string BrojKreditneKartice { get => brojKreditneKartice; set => brojKreditneKartice = value; }
        public string Username { get => username; set => username = value; }
        public string Sifra { get => sifra; set => sifra = value; }
        public virtual Profil Profil { get => profil; set => profil = value; }
    }
}