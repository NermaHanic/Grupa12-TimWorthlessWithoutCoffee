using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using Microsoft.WindowsAzure.MobileServices;
using DearWalletDressMeUp.Helper;
using DearWalletDressMeUp.Model;

namespace DearWalletDressMeUp.ViewModel
{
    public class KorisnikViewModel:INotifyPropertyChanged
    {
        private Korisnik korisnik;
        private string pSifra;
        public ICommand UnesiUBazu { get; set; }
        public INavigacija Navigacija { get; set; }
        public string PSifra { get => pSifra; set { pSifra = value; OnPropertyChanged("pSifra"); } }
        public Korisnik Korisnik
        {
            get { return korisnik; }
            set { korisnik = value; OnPropertyChanged("Korisnik"); }
        }

        public KorisnikViewModel()
        {
            UnesiUBazu = new RelayCommand<object>(DodajUBazu);
            korisnik = new Korisnik();
            Navigacija = new Navigacija();
        }
        
        public async void DodajUBazu(object parametar)
        {
            string greska = "";
            Tuple<bool, string> var = Pomocna.ValidirajPolja(korisnik.Ime, korisnik.Prezime, korisnik.Sifra, pSifra, korisnik.Adresa,korisnik.Email, korisnik.BrojTel.ToString());
            Tuple<bool, string> sifrice = Pomocna.ValidirajSifre(korisnik.Sifra, pSifra);
            Tuple<bool, string> tel = Pomocna.ValidirajTelefon(korisnik.BrojTel);
            Tuple<bool, string> kr = Pomocna.ValidirajKreditnu(korisnik.BrojKreditneKartice);
            if (var.Item1 == false)
            {
                greska += var.Item2+"\n";
            }
            else if (sifrice.Item1 == false)
            {
                greska += sifrice.Item2+"\n";
            }
            else if (tel.Item1 == false)
            {
                greska = tel.Item2+"\n";
            }
            else if (kr.Item1 == false)  //trebalo bi ovaj kod malkice dotjerati
            {
                greska = kr.Item2+"\n";
            }
            if (greska != "")
            {
                await new MessageDialog(greska).ShowAsync();
            }
            else
            {
                try
                {
                    
                    IMobileServiceTable<Korisnik> korisnik = App.MobileService.GetTable<Korisnik>();
                    Korisnik objProf = new Korisnik();
                    objProf.Ime = Korisnik.Ime;
                    objProf.Prezime = Korisnik.Prezime;
                    objProf.Sifra = Korisnik.Sifra;
                    objProf.Adresa = Korisnik.Adresa;
                    objProf.BrojKreditneKartice = Korisnik.BrojKreditneKartice;
                    objProf.BrojTel = Korisnik.BrojTel;
                    objProf.Email = Korisnik.Email;
                    objProf.Id = Korisnik.Id;
                    await korisnik.InsertAsync(objProf);
                    
                    MessageDialog m = new MessageDialog("Uspjesno ste registrovani na Dear Wallet Dress Me Up!  :)");
                    await m.ShowAsync();
                    Navigacija.Navigiraj(typeof(Login));
                }
                catch (Exception ex)
                {
                    MessageDialog feedbackError = new MessageDialog("Error : Doslo je do greske! \n" + ex.ToString());
                    await feedbackError.ShowAsync();
                }
            }
        }
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
