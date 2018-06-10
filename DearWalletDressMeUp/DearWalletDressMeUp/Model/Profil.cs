using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using System.ComponentModel;

namespace DearWalletDressMeUp.Model
{
    public class Profil : IIzmjene, IKupovina, IKreacijeNaProfilu, INotifyPropertyChanged
    {
        private string id;
        private BitmapImage slikaProfila;
        private List<Kreacija> listaKreacija;
        private string idKorisnika;

        public Profil(string idProfila, BitmapImage slikaProfila, List<Kreacija> listaKreacija, string idKorisnika)
        {
            this.id = idProfila;
            this.slikaProfila = slikaProfila;
            this.idKorisnika = idKorisnika;
            this.listaKreacija = listaKreacija;
        }
        public Profil()
        { }
        public string Id { get => id; set => id = value; }
        public BitmapImage SlikaProfila { get => slikaProfila; set => slikaProfila = value; }
        public List<Kreacija> ListaKreacija { get => listaKreacija; set => listaKreacija = value; }
        public string IdKorisnika { get => idKorisnika; set => idKorisnika = value; }

        public void BrisanjeProfila()
        {

        }
        public void PreporuciPrijatelju(string emailAdresa) { }

        public void IzmijeniIme(string novoIme) { }
        public void IzmijeniPrezime(string novoPrezime) { }
        public void IzmijeniAdresu(string novaAdresa) { }
        public void IzmijeniBrojTelefona(string korisnikBrojTelefona) { }
        public void IzmijeniBrojKreditneKartice(string korisnikBrojKreditneKartice) { }
        public void IzmijeniSifru(string novaSifra) { }
        public void IzmijeniSliku(BitmapImage novaSlika) { }
        public void DodajUKorpicu() { }
        public void DodajKreaciju(string idKreacije) { }
        public void ObrisiKreaciju(string idKreacije) { }

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
