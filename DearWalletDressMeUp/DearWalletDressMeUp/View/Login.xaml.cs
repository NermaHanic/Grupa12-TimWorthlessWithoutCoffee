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
using Microsoft.WindowsAzure.MobileServices;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DearWalletDressMeUp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
        }

        private async void Loginbtn_Click(object sender, RoutedEventArgs e)
        {
            error.Text = "";

            if (tekst.Text.Length == 0 || sifra.Password.Length == 0)
            {
                error.Text = "Niste unijeli sva polja";
            }
            else if (ime.Text == "admin")
            {
                Frame.Navigate(typeof(AdminovProfil));
            }
            else if (ime.Text != "admin")
            {
                IMobileServiceTable<Korisnik> tabela = App.MobileService.GetTable<Korisnik>();
                List<Korisnik> l = await tabela.ToListAsync();
                try
                {
                    Korisnik dummy = l.Find(x => x.Id == ime.Text);
                    if (dummy.Sifra != sifra.Password)
                    {
                        error.Text = "Username i sifra se ne slazu.";
                    }
                }
                catch
                {
                    ContentDialog errorMsg = new ContentDialog()
                    {
                        Title = "Oops",
                        Content = "Vi nemate kreiran profil :( Molimo, registrujte se.",
                        CloseButtonText = "Ok"
                    };
                    await errorMsg.ShowAsync();
                }
            }
            else
            {
                Frame.Navigate(typeof(Home));
            }
        }

        private void pink_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Registracija));
        }
    }
}
