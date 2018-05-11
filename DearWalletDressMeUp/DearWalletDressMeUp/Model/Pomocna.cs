using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;

namespace DearWalletDressMeUp.Model
{
    public static class Pomocna
    {
        public async static Task<string> DodjelaUsername(string ime, string prezime)
        {
            IMobileServiceTable<Korisnik> tabelica = App.MobileService.GetTable<Korisnik>();
            List<Korisnik> lista = await tabelica.ToListAsync();
            return ime.ToLower()[0] + prezime.ToLower() + (lista.FindAll(x => (x.Ime[0] == ime[0] && x.Prezime == prezime)).Count()+1).ToString();
        }
    }
}
