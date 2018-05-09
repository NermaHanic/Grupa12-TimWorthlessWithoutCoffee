using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Korisnik
    {
        private string ime;
        private string prezime;
        private string email;
        private string adresa;
        private string brojTelefona;
        private string brojKreditneKartice;
        private string id;
        private string sifra;

        public Korisnik(string ime, string prezime, string email, string adresa, string brojTelefona, string brojKreditneKartice, string id, string sifra)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.Adresa = adresa;
            this.BrojTelefona = brojTelefona;
            this.BrojKreditneKartice = brojKreditneKartice;
            this.Id = id;
            this.Sifra = sifra;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        public string BrojKreditneKartice { get => brojKreditneKartice; set => brojKreditneKartice = value; }
        public string Id { get => id; set => id = value; }
        public string Sifra { get => sifra; set => sifra = value; }
    }
}
