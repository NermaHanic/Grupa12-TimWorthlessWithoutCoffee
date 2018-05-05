using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DearWalletDressMeUp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Pregled_profila : Page
    {
        public Pregled_profila()
        {
            this.InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Home));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Home));
        }

        private void PreporuciPrijatelju_Click(object sender, RoutedEventArgs e)
        {

        }
        

        private void IzmijeniLicne_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void IzmijeniSliku_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker fop = new FileOpenPicker();
            fop.FileTypeFilter.Add(".jpg");
            fop.FileTypeFilter.Add(".png");
            fop.FileTypeFilter.Add(".jpeg");
            StorageFile file = await fop.PickSingleFileAsync();
            if (file != null)
            {
                var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                var image = new BitmapImage();
                image.SetSource(stream);
                userSlika.Source = image;
            }
        }

        private void BrisanjeProfila_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DodajKorpica_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DodajKreaciju_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Kreacija1));
        }
        
    }
}
