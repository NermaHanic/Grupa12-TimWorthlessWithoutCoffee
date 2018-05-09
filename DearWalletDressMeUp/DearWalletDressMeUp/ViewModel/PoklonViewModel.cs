using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace DearWalletDressMeUp.ViewModel
{
    public class PoklonViewModel
    {
        public ICommand SnimiPoruku;

        public PoklonViewModel()
        {
            SnimiPoruku = new RelayCommand(snimiPoruku);
        }

        public void snimiPoruku(object param) { }
    }
}
