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
        IMobileServiceTable<Profil> profil = App.MobileService.GetTable<Profil>();
        private async void DodajKorUBazu_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                /* Korisnik obj = new Korisnik(, , ,,
                     , , 
                     , );*/
                Korisnik obj = new Korisnik();
                obj.Ime = ImeKorAdminText.Text;
                obj.Prezime = PrezimeKorAdminText.Text;
                obj.Email = EmailKorAdminText.Text;
                obj.Adresa = AdresaKorAdminText.Text;
                obj.BrojTelefona = BrojTelKorAdminText.Text;
                obj.BrojKreditneKartice = BrojKreditneKarticeKorAdminText.Text;
                obj.Sifra = SifraKorAdminText.Password;
                obj.Id = await Pomocna.DodjelaUsername(ImeKorAdminText.Text, PrezimeKorAdminText.Text);

                Profil objProf = new Profil();
                objProf.Id = await ID<Profil>.DodjelaID(profil);
                objProf.IdKorisnika = obj.Id;
                obj.IdProfila = objProf.Id;

                await profil.InsertAsync(objProf);
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

        private async void BrisiKorIzBaze_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Korisnik kor = (await tabelica.ToListAsync()).Find(x => x.Id == IDProfilaBrisanjeText.Text);
                await tabelica.DeleteAsync(kor);
                MessageDialog msg = new MessageDialog("Uspjesno ste obrisali korisnika.");
                await msg.ShowAsync();
            }
            catch (Exception)
            {
                MessageDialog msgError = new MessageDialog("Ne postoji korisnik sa tim username-om.");
                await msgError.ShowAsync();
            }

        }
    }
}
