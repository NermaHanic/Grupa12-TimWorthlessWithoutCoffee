using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DearWalletDressMeUp.Helper;
using System.Windows.Input;
using DearWalletDressMeUp.Helper;

namespace DearWalletDressMeUp.ViewModel
{
    public class PoklonViewModel
    {
        public ICommand snimiPoruku;

        public PoklonViewModel()
        {
<<<<<<< HEAD
            snimiPoruku = new RelayCommand<object>(SnimiPoruku);
=======
            SnimiPoruku = new RelayCommand<object>(snimiPoruku);
>>>>>>> fdfdfd4ab3669d3bcb126d8aacfaccfdbfb2d990
        }

        public void SnimiPoruku(object param) { }
    }
}
