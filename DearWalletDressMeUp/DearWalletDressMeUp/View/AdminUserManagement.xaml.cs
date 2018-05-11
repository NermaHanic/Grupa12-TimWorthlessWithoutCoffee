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
using Microsoft.WindowsAzure.MobileServices;
using DearWalletDressMeUp.Model;
using Windows.UI.Popups;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DearWalletDressMeUp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminUserManagement : Page
    {
        public AdminUserManagement()
        {
            this.InitializeComponent();
        }
        
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminovProfil));
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }
        IMobileServiceTable<Korisnik> tabelica = App.MobileService.GetTable<Korisnik>();
        //IMobileServiceTable<Profil> profil = App.MobileService.GetTable<Profil>();
        private async void DodajKorUBazu_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Korisnik obj = new Korisnik(ImeKorAdminText.Text, PrezimeKorAdminText.Text, EmailKorAdminText.Text, AdresaKorAdminText.Text,
                    BrojTelKorAdminText.Text, BrojKreditneKarticeKorAdminText.Text, 
                    await Pomocna.DodjelaUsername(ImeKorAdminText.Text, PrezimeKorAdminText.Text), SifraKorAdminText.Password);
               
                /*Profil objProf = new Profil();
                objProf.Id = await ID<Profil>.DodjelaID(profil);
                await profil.InsertAsync(objProf);*/
                await tabelica.InsertAsync(obj);
                MessageDialog feedback = new MessageDialog("Uspjesno ste dodali korisnika");
                await feedback.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog feedbackError = new MessageDialog("Error : Doslo je do greske! \n" + ex.ToString());
                await feedbackError.ShowAsync();
            }

        }

        private void UsernameKorAdminText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
