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
        private string brojTel;
        private string brojKreditneKartice;
        private int id;
        private string sifra;
        private string username;

        public Korisnik()
        { }

        public Korisnik(string ime, string prezime, string email, string adresa, string brojTel, string brojKreditneKartice, int id, string sifra, string username)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.Adresa = adresa;
            this.BrojTel = brojTel;
            this.BrojKreditneKartice = brojKreditneKartice;
            this.Id = id;
            this.Sifra = sifra;
            this.username = username;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string BrojTel { get => brojTel; set => brojTel = value; }
        public string BrojKreditneKartice { get => brojKreditneKartice; set => brojKreditneKartice = value; }
        public int Id { get => id; set => id = value; }
        public string Sifra { get => sifra; set => sifra = value; }
        public string Username { get => username; set => username = value; }

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
