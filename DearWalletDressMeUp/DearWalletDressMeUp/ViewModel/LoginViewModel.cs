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
using Windows.UI.Xaml.Controls;

namespace DearWalletDressMeUp.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private Korisnik korisnik;
        public INavigacija Navigacija { get; set; }
        public ICommand Logiranje { get; set; }

        public Korisnik Korisnik
        {
            
            get { return korisnik; }
            set { korisnik = value; OnPropertyChanged("Korisnik"); }
        }

        public LoginViewModel()
        {
            Logiranje = new RelayCommand<object>(Login);
            korisnik = new Korisnik();
            Navigacija = new Navigacija();
        }

        public async void Login(object parametar)
        {
            string greska = "";

           Tuple<bool, string> admin = Pomocna.JeLAdmin(korisnik.Id);
           Tuple<bool, string, Korisnik> meh = await Pomocna.ValidacijaLogina(korisnik.Id, korisnik.Sifra);

            if (admin.Item1)
            {
                Navigacija.Navigiraj(typeof(AdminovProfil));
            }
            else if (!(meh.Item1))
            {
                greska += meh.Item2;
                if (meh.Item2 == "nr")
                {
                    ContentDialog errorMsg = new ContentDialog()
                    {
                        Title = "Oops",
                        Content = "Vi nemate kreiran profil :( Molimo, registrujte se.",
                        CloseButtonText = "Ok"
                    };
                    await errorMsg.ShowAsync();
                }
                else await (new MessageDialog(greska)).ShowAsync();
            }
            
            else
            {
                Pomocna.UlogovaniKorisnik = korisnik.Id;
                
                Navigacija.Navigiraj(typeof(Home), meh.Item3);
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

