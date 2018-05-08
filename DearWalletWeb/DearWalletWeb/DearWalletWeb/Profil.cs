using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Profil : IKupovina, IKreacijeNaProfilu, IIzmjene
    {
        private string id;
        private string slika;
        //povezivanje
        private Korisnik korisnik;
        private ICollection<Narudzba> narudzba;
        private ICollection<Kreacija> kreacija;


        public string Id { get => id; set => id = value; }
        public string Slika { get => slika; set => slika = value; }
        public virtual Korisnik Korisnik { get => korisnik; set => korisnik = value; }
        public virtual ICollection<Narudzba> Narudzba { get => narudzba; set => narudzba = value; }
        public virtual ICollection<Kreacija> Kreacija { get => kreacija; set => kreacija = value; }

        public void BrisanjeProfila() { }
        public void PreporuciPrijatelju(string emailAdresa) { }

        public void IzmjeniIme(string novoIme) { }
        public void IzmjeniPrezime(string novoPrezime) { }
        public void IzmjeniAdresu(string novaAdresa) { }
        public void IzmjeniBrojTelefona(string noviBrojTel) { }
        public void IzmjeniBrojKrediteneKartice(string noviBrojKredKart) { }
        public void IzmjeniSifru(string novaSifra) { }
        public void IzmjeniSliu(string novaSlika) { }

        public void DodajKreaciju() { }
        public void Obrisikreaciju(string sifraKreacije) { }
        public void DodajUKorpicu(string a) { }
    }
}
