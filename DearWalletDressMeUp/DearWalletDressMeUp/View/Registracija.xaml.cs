using DearWalletDressMeUp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.WindowsAzure.MobileServices;
using DearWalletDressMeUp.ViewModel;
<<<<<<< HEAD
using DearWalletDressMeUp.Helper;
=======
>>>>>>> fdfdfd4ab3669d3bcb126d8aacfaccfdbfb2d990
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DearWalletDressMeUp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registracija : Page
    {
        public Registracija()
        {
            this.InitializeComponent();
            DataContext = new KorisnikViewModel();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }
<<<<<<< HEAD
       
=======
        IMobileServiceTable<Korisnik> tabelica = App.MobileService.GetTable<Korisnik>();
        private async void Registruj_Click(object sender, RoutedEventArgs e)
        {
            error.Text = "";
            if (ime.Text.Length == 0 || prezime.Text.Length == 0 || sifra.Password.Length == 0 || potvrdaSifre.Password.Length == 0 || adresa.Text.Length == 0 || telefon.Text.Length == 0)
            {
                error.Text = "Niste unijeli sva obavezna polja.";
            }

            else if (potvrdaSifre.Password != sifra.Password)
            {
                error.Text = "Unesene sifre se ne slazu.";
            }

            else
            {
                for (int i = 0; i < telefon.Text.Length; i++)
                {
                    if (Char.IsLetter(telefon.Text[i])) error.Text = "Neispravan format broja telefona";
                }
                for (int i = 0; i < kartica.Text.Length; i++)
                {
                    if (Char.IsLetter(kartica.Text[i])) error.Text = "Neispravan format broja kreditne kartice";
                }
            }

            if (error.Text == "")
            {
                KorisnikViewModel k = new KorisnikViewModel();
                k.dodajUBazu(true);
            }
        }
>>>>>>> fdfdfd4ab3669d3bcb126d8aacfaccfdbfb2d990
    }
}
