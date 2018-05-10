using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using DearWalletDressMeUp.Model;

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
    public sealed partial class AdminovProfil : Page
    {
        
        public AdminovProfil()
        {
            this.InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DodajOdj_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminDodavanjeOdjece));
        }
        IMobileServiceTable<Korisnik> tabelica = App.MobileService.GetTable <Korisnik>();

        private void DodajBrisiKor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Korisnik obj = new Korisnik();

                
                tabelica.InsertAsync(obj);
                MessageDialog feedback = new MessageDialog("Uspjesno ste dodali korisnika");
                feedback.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog feedbackError = new MessageDialog("Error : Doslo je do greske! \n" + ex.ToString());
                feedbackError.ShowAsync();
            }


            Frame.Navigate(typeof(AdminUserManagement));
        }
    }
}
