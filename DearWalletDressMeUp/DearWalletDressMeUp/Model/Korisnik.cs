using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Korisnik : INotifyPropertyChanged
    {
        private string ime;
        private string prezime;
        private string email;
        private string adresa;
        private string brojTelefona;
        private string brojKreditneKartice;
        private string id;
        private string sifra;
        private string idProfila;

        public Korisnik()
        { }

        public Korisnik(string ime, string prezime, string email, string adresa, string brojTelefona, string brojKreditneKartice, string id, string sifra, string idProfila)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.Adresa = adresa;
            this.BrojTelefona = brojTelefona;
            this.BrojKreditneKartice = brojKreditneKartice;
            this.Id = id;
            this.Sifra = sifra;
            this.idProfila = idProfila;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        public string BrojKreditneKartice { get => brojKreditneKartice; set => brojKreditneKartice = value; }
        public string Id { get => id; set => id = value; }
        public string Sifra { get => sifra; set => sifra = value; }
        public string IdProfila { get => idProfila; set => idProfila = value; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
