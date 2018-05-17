using DearWalletDressMeUp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Windows.Input;
using Microsoft.WindowsAzure.MobileServices;
using DearWalletDressMeUp.Helper;

namespace DearWalletDressMeUp.ViewModel
{
    public class KorisnikViewModel
    {
         //public ICommand DobaviIzBaze { get; set; }
        public ICommand UnesiUBazu { get; set; }
         //public ICommand UnesiViseUBazu { get; set; }
        //List<Korisnik> korisnici;
        public Korisnik korisnik { get; set; }

        public KorisnikViewModel()
        {
            //DobaviIzBaze = new RelayCommand<object>();
            UnesiUBazu = new RelayCommand<object>(dodajUBazu);
            //UnesiViseUBazu = new RelayCommand<object>();
            //korisnici = new List<Korisnik>();
        }

        IMobileServiceTable<Korisnik> tabelica = App.MobileService.GetTable<Korisnik>();

        public async void dodajUBazu(object parametar)
        {
                try
                {
                    /*Korisnik obj = new Korisnik(ime.Text, prezime.Text, EmailReg.Text, adresa.Text, telefon.Text, kartica.Text,
                        await Pomocna.DodjelaUsername(ime.Text, prezime.Text), sifra.Password);
                    await tabelica.InsertAsync(obj);

                    /*IMobileServiceTable<Profil> profil = App.MobileService.GetTable<Profil>();
                    Profil objProf = new Profil();
                    objProf.Id = await ID<Profil>.DodjelaID(profil);
                    await profil.InsertAsync(objProf);*/

                    Korisnik obj = new Korisnik();
                    obj.Ime = korisnik.Ime;
                    obj.Prezime = korisnik.Prezime;
                    obj.Prezime = korisnik.Sifra;
                    obj.Email = korisnik.Email;
                    obj.Adresa = korisnik.Adresa;
                    obj.BrojTelefona = korisnik.BrojTelefona;
                    obj.BrojKreditneKartice = korisnik.BrojKreditneKartice;
                    obj.Sifra = korisnik.Sifra;
                    obj.Id = await Pomocna.DodjelaUsername(obj.Ime, obj.Prezime);

                await tabelica.InsertAsync(obj);

                MessageDialog m = new MessageDialog("Uspjesno ste registrovani na Dear Wallet Dress Me Up! Vas username glasi: " + obj.Id + " :)");
                    await m.ShowAsync();
                    Navigacija.Navigiraj(typeof(Home));
                    
                   
                }
                catch (Exception ex)
                {
                    MessageDialog feedbackError = new MessageDialog("Error : Doslo je do greske! \n" + ex.ToString());
                    await feedbackError.ShowAsync();
                }
            }
        
    }
}
