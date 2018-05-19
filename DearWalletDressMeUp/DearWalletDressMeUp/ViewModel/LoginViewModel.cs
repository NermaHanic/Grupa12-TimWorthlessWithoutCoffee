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
        public ICommand RegistrujSe { get; set; }

        public Korisnik Korisnik
        {
            get { return korisnik; }
            set { korisnik = value; OnPropertyChanged("Korisnik"); }
        }

        public LoginViewModel()
        {
            RegistrujSe = new RelayCommand<object>(Login);
            korisnik = new Korisnik();
            Navigacija = new Navigacija();
        }

        public async void Login(object parametar)
        {
            string greska = "";
            Tuple<bool, string> polja = Pomocna.ValidirajLogin(korisnik.Ime, korisnik.Sifra);
            Tuple<bool, string> admin = Pomocna.JeLAdmin(korisnik.Ime);

            if (!polja.Item1)
            {
                greska += polja.Item2 + "\n";
            }
            else if (admin.Item1)
            {
                Navigacija.Navigiraj(typeof(AdminovProfil));
            }
            else if (!admin.Item1)
            {
                IMobileServiceTable<Korisnik> tabela = App.MobileService.GetTable<Korisnik>();
                List<Korisnik> l = await tabela.ToListAsync();
                try
                {

                    greska = await Pomocna.ValidacijaLogina(korisnik.Id, korisnik.Sifra);
                }
                catch
                {
                    ContentDialog errorMsg = new ContentDialog()
                    {
                        Title = "Oops",
                        Content = "Vi nemate kreiran profil :( Molimo, registrujte se.",
                        CloseButtonText = "Ok"
                    };
                    await errorMsg.ShowAsync();
                }
            }
            else
            {
                Navigacija.Navigiraj(typeof(Home));
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

