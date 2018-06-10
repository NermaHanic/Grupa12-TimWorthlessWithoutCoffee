using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DearWalletDressMeUp.Helper;
using System.Windows.Input;

namespace DearWalletDressMeUp.ViewModel
{
    public class PoklonViewModel
    {
        public ICommand snimiPoruku;

        public PoklonViewModel()
        {
            snimiPoruku = new RelayCommand<object>(SnimiPoruku);
        }

        public void SnimiPoruku(object param) { }
    }
}
