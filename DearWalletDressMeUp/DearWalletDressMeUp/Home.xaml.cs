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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DearWalletDressMeUp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
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
            Frame.Navigate(typeof(Pregled_profila));
        }

        private void Kviz_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Kviz1));
        }
    }
}
