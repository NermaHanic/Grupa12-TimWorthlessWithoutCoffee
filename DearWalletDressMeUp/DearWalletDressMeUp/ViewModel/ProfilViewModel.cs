using System;
using DearWalletDressMeUp.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DearWalletDressMeUp.Helper;
using System.Windows.Input;

namespace DearWalletDressMeUp.ViewModel
{
    public class ProfilViewModel
    {
        public ICommand BrisiProfil { get; set; }
        public ICommand Preporuci { get; set; }
        
        public ProfilViewModel()
        {
            BrisiProfil = new RelayCommand<object>(Brisi);
            Preporuci = new RelayCommand<object>(PreporuciPrijatelju);
        }
        public void Brisi(object parametar) { }
        public void PreporuciPrijatelju(object param) { }
        
    }
}
