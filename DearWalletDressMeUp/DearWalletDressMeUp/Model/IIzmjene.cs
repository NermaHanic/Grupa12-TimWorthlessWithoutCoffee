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
        void IzmijeniBrojTelefona(string noviBrojTelefona);
        void IzmijeniBrojKreditneKartice(string noviBrojKreditneKartice);
        void IzmijeniSifru(string novaSifra);
        void IzmijeniSliku(BitmapImage novaSlika);

    }
}
