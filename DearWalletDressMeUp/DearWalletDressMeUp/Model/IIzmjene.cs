using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace DearWalletDressMeUp.Model
{
    interface IIzmjene
    {
        void IzmijeniIme(string novoIme);
        void IzmijeniPrezime(string novoPrezime);
        void IzmijeniAdresu(string novaAdresa);
        void IzmijeniBrojTelefona(string korisnikBrojTelefona);
        void IzmijeniBrojKreditneKartice(string korisnikBrojKreditneKartice);
        void IzmijeniSifru(string novaSifra);
        void IzmijeniSliku(BitmapImage novaSlika);

    }
}
