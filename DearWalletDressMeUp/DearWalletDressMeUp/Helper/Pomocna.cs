using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;
using DearWalletDressMeUp.Helper;

namespace DearWalletDressMeUp.Model
{
    public static class Pomocna
    {
        public static string UlogovaniKorisnik { get; set; }
        public async static Task<string> DodjelaUsername(string ime, string prezime)
        {
            IMobileServiceTable<Korisnik> tabelica = App.MobileService.GetTable<Korisnik>();
            List<Korisnik> lista = await tabelica.ToListAsync();
            int blah = 0;
            try
            {
                blah = lista.FindAll(x => (x.Ime[0] == ime[0] && x.Prezime == prezime)).Count();
            }
            catch (Exception)
            {
            }
            return ime.ToLower()[0] + prezime.ToLower() + (blah + 1).ToString();
        }
        
        public static Tuple<bool, string> ValidirajPolja(string ime, string prezime, string sifra, string psifra,string adresa, string email,string telefon)
        {
            if (string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime) || string.IsNullOrEmpty(sifra) || string.IsNullOrEmpty(psifra)
                || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(adresa) || string.IsNullOrEmpty(telefon))
            {
                return new Tuple<bool, string>(false, "Niste unijeli sva obavezna polja.");
            }
            return new Tuple<bool, string>(true, "");
        }
        public static Tuple<bool, string> ValidirajSifre(string sifra, string psifra)
        {
            if (sifra != psifra) return new Tuple<bool, string>(false, "Unesene sifre se ne slazu.");
            return new Tuple<bool, string>(true, "");
        }
        public static Tuple<bool, string> ValidirajTelefon(string telefon)
        {
            if (string.IsNullOrEmpty(telefon)) return new Tuple<bool, string>(false, "Neispravan format broja telefona");
            for (int i = 0; i < telefon.Length; i++)
            {
                if (Char.IsLetter(telefon[i])) return new Tuple<bool, string>(false, "Neispravan format broja telefona");
            }
            return new Tuple<bool, string>(true, "");
        }
        public static Tuple<bool, string> ValidirajKreditnu(string kr)
        {
            if (string.IsNullOrEmpty(kr)) return new Tuple<bool, string>(true, "");
            for (int i = 0; i < kr.Length; i++)
            {
                if (Char.IsLetter(kr[i])) new Tuple<bool, string>(false, "Neispravan format broja kreditne kartice");
            }
            return new Tuple<bool, string>(true, "");
        }
        
        public static Tuple<bool, string> JeLAdmin(string username)
        {
            if (username == "admin")
            {  //popravi ovo
                return new Tuple<bool, string>(true, "");
            }
            return new Tuple<bool, string>(false, "");
        }
        public async static Task<Tuple<bool, string, Korisnik>> ValidacijaLogina(string username,string password)
        {
            if(username is null || password is null)
            {
                return new Tuple<bool, string, Korisnik>(false, "Niste unijeli sva polja.", new Korisnik());
            }
            IMobileServiceTable<Korisnik> tabelica = App.MobileService.GetTable<Korisnik>();
            List<Korisnik> lista = await tabelica.ToListAsync();
            Korisnik kor = new Korisnik();
            if (!lista.Any(x => x.Id == username)) return new Tuple<bool, string, Korisnik>(false, "nr", new Korisnik());
            kor=lista.Find(x => x.Id == username);
            if (kor.Sifra != password) return new Tuple<bool, string, Korisnik>(false, "Username i sifra se ne slazu!", new Korisnik());
            return new Tuple<bool, string, Korisnik>(true, "", kor);
        }
        public async static Task<Tuple<bool, string>> ValidacijaNarudzbe(string adresa, string)
        { }
    }
}
