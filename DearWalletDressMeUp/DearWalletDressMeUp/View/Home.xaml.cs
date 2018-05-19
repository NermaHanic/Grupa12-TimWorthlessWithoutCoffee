using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using DearWalletDressMeUp.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DearWalletDressMeUp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        private string profil;
        private Korisnik _korLogin;
        public Home()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter is string)
            {
                profil = (string)e.Parameter;
            }
            else if (e.Parameter is Korisnik)
            {
                _korLogin = (Korisnik)e.Parameter;
            }
        }

        private void Kreiraj_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Kreacija1));
        }

        private void Pretraga_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pretraga));
        }

        private void MojProfil_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pregled_profila), profil);
        }

        private void Kviz_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Kviz1));
        }

        private void LogOutHome_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }
    }
}
