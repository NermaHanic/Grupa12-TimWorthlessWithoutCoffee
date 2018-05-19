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
    
        public ProfilViewModel()
        {
            BrisiProfil = new RelayCommand<object>(Brisi);
            Preporuci = new RelayCommand<object>(PreporuciPrijatelju);
        }
      

        public async void Brisi(object parametar) {
            string user = Pomocna.UlogovaniKorisnik;
            IMobileServiceTable<Korisnik> tabela = App.MobileService.GetTable<Korisnik>();
            List<Korisnik> l = await tabela.ToListAsync();
            for (int i = 0; i < l.Count(); i++)
            {
                if (l[i].Id == user)
                {
                    Korisnik k = l.Find(x => x.Id == user);
                    await tabela.DeleteAsync(k);
                    MessageDialog mg = new MessageDialog("Vas profil je uspjesno obrisan. Dovidjenja :)");
                    await mg.ShowAsync();
                    Application.Current.Exit();
                }
            }
        }
     

        public void PreporuciPrijatelju(object param) { }
        
    }
}
