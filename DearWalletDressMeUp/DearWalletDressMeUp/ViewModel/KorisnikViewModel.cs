using DearWalletDressMeUp.Model;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
<<<<<<< HEAD
using Windows.UI.Popups;
=======
using Microsoft.WindowsAzure.MobileServices;
>>>>>>> fdfdfd4ab3669d3bcb126d8aacfaccfdbfb2d990
using DearWalletDressMeUp.Helper;

namespace DearWalletDressMeUp.ViewModel
{
    public class KorisnikViewModel:INotifyPropertyChanged
    {
<<<<<<< HEAD
        private Korisnik korisnik;
        private string pSifra;
        public ICommand UnesiUBazu { get; set; }
        public INavigacija Navigacija { get; set; }
        public string PSifra { get => pSifra; set { pSifra = value; OnPropertyChanged("pSifra"); } }
        public Korisnik Korisnik
        {
            get { return korisnik; }
            set { korisnik = value; OnPropertyChanged("Korisnik"); }
        }

        public KorisnikViewModel()
        {
            UnesiUBazu = new RelayCommand<object>(DodajUBazu);
            korisnik = new Korisnik();
            Navigacija = new Navigacija();
        }
        
        public async void DodajUBazu(object parametar)
        {
            string greska = "";
            Tuple<bool, string> var = Pomocna.ValidirajPolja(korisnik.Ime, korisnik.Prezime, korisnik.Sifra, pSifra, korisnik.Adresa,korisnik.Email, korisnik.BrojTelefona);
            Tuple<bool, string> sifrice = Pomocna.ValidirajSifre(korisnik.Sifra, pSifra);
            Tuple<bool, string> tel = Pomocna.ValidirajTelefon(korisnik.BrojTelefona);
            Tuple<bool, string> kr = Pomocna.ValidirajKreditnu(korisnik.BrojKreditneKartice);
            if (var.Item1 == false)
            {
                greska += var.Item2+"\n";
            }
            else if (sifrice.Item1 == false)
            {
                greska += sifrice.Item2+"\n";
            }
            else if (tel.Item1 == false)
            {
                greska = tel.Item2+"\n";
            }
            else if (kr.Item1 == false)  //trebalo bi ovaj kod malkice dotjerati
            {
                greska = kr.Item2+"\n";
            }
            if (greska != "")
            {
                await new MessageDialog(greska).ShowAsync();
            }
            else
            {
                try
                {
                    IMobileServiceTable<Korisnik> tabelica = App.MobileService.GetTable<Korisnik>();
                    korisnik.Id = await Pomocna.DodjelaUsername(korisnik.Ime, korisnik.Prezime);
                    await tabelica.InsertAsync(korisnik);
=======
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
>>>>>>> fdfdfd4ab3669d3bcb126d8aacfaccfdbfb2d990

                    /*IMobileServiceTable<Profil> profil = App.MobileService.GetTable<Profil>();
                    Profil objProf = new Profil();
                    objProf.Id = await ID<Profil>.DodjelaID(profil);
                    await profil.InsertAsync(objProf);*/

<<<<<<< HEAD
                    MessageDialog m = new MessageDialog("Uspjesno ste registrovani na Dear Wallet Dress Me Up! Vas username glasi: " + korisnik.Id + " :)");
                    await m.ShowAsync();
                    Navigacija.Navigiraj(typeof(Login));
=======
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
                    
                   
>>>>>>> fdfdfd4ab3669d3bcb126d8aacfaccfdbfb2d990
                }
                catch (Exception ex)
                {
                    MessageDialog feedbackError = new MessageDialog("Error : Doslo je do greske! \n" + ex.ToString());
                    await feedbackError.ShowAsync();
                }
            }
<<<<<<< HEAD
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
=======
        
>>>>>>> fdfdfd4ab3669d3bcb126d8aacfaccfdbfb2d990
    }
}
