using System;
using DearWalletDressMeUp.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DearWalletDressMeUp.Helper;
using System.Windows.Input;
using Windows.UI.Popups;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Xaml;
using System.ComponentModel;

namespace DearWalletDressMeUp.ViewModel
{
    public class ProfilViewModel { 
        public ICommand BrisiProfil { get; set; }
        public ICommand Preporuci { get; set; }
        public Navigacija nav;
    
        public ProfilViewModel()
        {
            BrisiProfil = new RelayCommand<object>(Brisi);
            Preporuci = new RelayCommand<object>(PreporuciPrijatelju);
            nav = new Navigacija();
        }
      

        public async void Brisi(object parametar) {
            string user = Pomocna.UlogovaniKorisnik;
            IMobileServiceTable<Korisnik> tabela = App.MobileService.GetTable<Korisnik>();
            IMobileServiceTable<Profil> profil = App.MobileService.GetTable<Profil>();
            List<Profil> p = await profil.ToListAsync();
            List<Korisnik> l = await tabela.ToListAsync();
            for (int i = 0; i < l.Count(); i++)
            {
                if (l[i].Id == user)
                {
                    Korisnik k = l.Find(x => x.Id == user);
                    await tabela.DeleteAsync(k);
                    Profil pr = p.Find(x => x.Id == k.IdProfila);
                    await profil.DeleteAsync(pr);
                    MessageDialog mg = new MessageDialog("Vas profil je uspjesno obrisan. Dovidjenja :)");
                    await mg.ShowAsync();
                    nav.Navigiraj(typeof(Login));
                }
            }
        }
     

        public void PreporuciPrijatelju(object param) { }
        
    }
}
