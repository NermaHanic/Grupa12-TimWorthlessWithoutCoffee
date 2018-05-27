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
    public sealed partial class Checkout : Page
    {
        private Korisnik _korLogin;
        public Checkout()
        {
            this.InitializeComponent();
        }

        private void OtkaziNarudzbu_Click(object sender, RoutedEventArgs e)
        {
            
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if(e.Parameter is Korisnik)
            {
                _korLogin = (Korisnik)e.Parameter;
            }
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Home),_korLogin);
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }

        private void Back1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pregled_profila),_korLogin);
        }

        private async void Potvrdi_Click(object sender, RoutedEventArgs e)
        {
           /* double cijena = Convert.ToDouble(Total.Text);
            string id = await ID<Narudzba>.DodjelaID();
            List<StavkeNarudzbe> lista = {new StavkeNarudzbe(id,) };  //ovdje myb factory? 
            Narudzba nova = new Narudzba(id,cijena,
            */
        }
    }
}
