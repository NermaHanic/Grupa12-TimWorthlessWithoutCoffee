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
    public class NarudzbaViewModel
    {
        public ICommand provjeraZaPoklon;
        public ICommand obracunCijene;
        public ICommand dodajStavku;

        public NarudzbaViewModel()
        {
            provjeraZaPoklon = new RelayCommand<object>(ProvjeraZaPoklon);
            obracunCijene = new RelayCommand<object>(ObracunajCijenu);
            dodajStavku = new RelayCommand<object>(DodajStavkuNarudzbe);
        }

        public void ProvjeraZaPoklon(object param) { }
        public void ObracunajCijenu(object param) { }
        public void DodajStavkuNarudzbe(object param) { }

    }
}
