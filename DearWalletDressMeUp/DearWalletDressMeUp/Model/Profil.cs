using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace DearWalletDressMeUp.Model
{
    public class Profil:IIzmjene,IKupovina,IKreacijeNaProfilu
    {
        private string id;
        private BitmapImage slikaProfila;
        private List<Kreacija> listaKreacija;

        public Profil(string idProfila, BitmapImage slikaProfila, List<Kreacija> listaKreacija)
        {
            this.id = idProfila;
            this.slikaProfila = slikaProfila;
            this.listaKreacija = listaKreacija;
        }
        public Profil()
        { }
        public string Id { get => id; set => id = value; }
        public BitmapImage SlikaProfila { get => slikaProfila; set => slikaProfila = value; }
        public List<Kreacija> ListaKreacija { get => listaKreacija; set => listaKreacija = value; }

        public void BrisanjeProfila()
        {
           
        } 
        public void PreporuciPrijatelju(string emailAdresa) { }

        public void IzmijeniIme(string novoIme) { }
        public void IzmijeniPrezime(string novoPrezime) { }
        public void IzmijeniAdresu(string novaAdresa) { }
        public void IzmijeniBrojTelefona(string noviBrojTelefona) { }
        public void IzmijeniBrojKreditneKartice(string noviBrojKreditneKartice) { }
        public void IzmijeniSifru(string novaSifra) { }
        public void IzmijeniSliku(BitmapImage novaSlika) { }
        public void DodajUKorpicu() { }
        public void DodajKreaciju(string idKreacije) { }
        public void ObrisiKreaciju(string idKreacije) { }
    }
}
