using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Profil : IKupovina, IKreacijeNaProfilu, IIzmjene
    {

        
        public string ProfilId { get; set; }
        public string Slika { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual ICollection<Narudzba> Narudzba { get; set; }
        public virtual ICollection<Kreacija> Kreacija { get; set; }

     
        //povezivanje
        private Korisnik korisnik;
        private ICollection<Narudzba> narudzba;

        

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
