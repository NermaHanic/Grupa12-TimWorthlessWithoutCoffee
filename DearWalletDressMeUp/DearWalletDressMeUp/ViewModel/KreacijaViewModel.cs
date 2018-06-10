using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DearWalletDressMeUp.Helper;


namespace DearWalletDressMeUp.ViewModel
{
    public class KreacijaViewModel
    {
        public ICommand ObracunCijene;

        public KreacijaViewModel()
        {
            ObracunCijene = new RelayCommand<object>(Obracunaj);
        }

        public void Obracunaj(object param) { }
    }
}
