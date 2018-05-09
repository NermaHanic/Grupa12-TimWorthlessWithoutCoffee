using System;
using DearWalletDressMeUp.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DearWalletDressMeUp.ViewModel
{
    public class ProfilViewModel
    {
        public ICommand BrisiProfil { get; set; }
        public ICommand Preporuci { get; set; }

        

        public ProfilViewModel()
        {
            BrisiProfil = new RelayCommand(brisi);
            Preporuci = new RelayCommand(preporuciPrijatelju);
        }
        public void brisi(object parametar) { }
        public void preporuciPrijatelju(object param) { }

        
    }
}
