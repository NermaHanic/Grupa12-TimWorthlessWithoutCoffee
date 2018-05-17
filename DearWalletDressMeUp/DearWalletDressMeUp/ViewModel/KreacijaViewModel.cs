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
<<<<<<< HEAD
            ObracunCijene = new RelayCommand<object>(Obracunaj);
=======
            ObracunCijene = new RelayCommand<object>(obracunaj);
>>>>>>> fdfdfd4ab3669d3bcb126d8aacfaccfdbfb2d990
        }

        public void Obracunaj(object param) { }
    }
}
