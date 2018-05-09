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
    public sealed partial class Poklon1 : Page
    {
        public Poklon1()
        {
            this.InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {

        }

        private void zelim_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Poklon2));
        }

        private void nezelim_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Checkout));
        }


        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {

            await c.ShowAsync();
        }



        private void c_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

            Frame.Navigate(typeof(Poklon2));

        }

        private void c_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            Frame.Navigate(typeof(Checkout));
        }
    }
}
