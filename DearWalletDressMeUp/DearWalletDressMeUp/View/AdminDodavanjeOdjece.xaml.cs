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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using DearWalletDressMeUp.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DearWalletDressMeUp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminDodavanjeOdjece : Page
    {
        public AdminDodavanjeOdjece()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminovProfil));
        }
        

        private async void OdaberiSlikuOdjece_Click(object sender, RoutedEventArgs e)
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
                SlikaAdminDodavanje.Source = image;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminovProfil));
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }

        IMobileServiceTable<OdjevniPredmet> tabelica = App.MobileService.GetTable<OdjevniPredmet>();
        private void DodajOdjevniPredmet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OdjevniPredmet obj = new OdjevniPredmet();
                obj.Id = IDTextOdjeca.Text;
                obj.Naziv = NazivTextOdjeca.Text;
                obj.Cijena =Convert.ToDouble(CijenaTextOdjeca.Text);
                obj.Slika = SlikaAdminDodavanje.Source.ToString();
                tabelica.InsertAsync(obj);
                MessageDialog feedback = new MessageDialog("Uspjesno ste dodali odjevni predmet.");
                feedback.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog feedbackError = new MessageDialog("Error : " + ex.ToString());
                feedbackError.ShowAsync();
            }
         }
    }
}
