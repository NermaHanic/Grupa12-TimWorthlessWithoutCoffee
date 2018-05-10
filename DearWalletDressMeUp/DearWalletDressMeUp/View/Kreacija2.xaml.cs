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
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DearWalletDressMeUp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Kreacija2 : Page
    {
        Kreacija1 k;
        public Kreacija2()
        {
            this.InitializeComponent();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Kreacija1));
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Home));
        }

        private void PitajStilistu_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Kreacija3));
        }

        private void Zavrsi_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pregled_profila));
        }

        private void Nastavi_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Kreacija1));
        }

        private void Odustani_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Home));
        }

    }
}

