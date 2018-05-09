using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace DearWalletDressMeUp.ViewModel
{
    public class KreacijaViewModel
    {
        public ICommand ObracunCijene;

        public KreacijaViewModel()
        {
            ObracunCijene = new RelayCommand(obracunaj);
        }

        public void obracunaj(object param) { }
    }
}
