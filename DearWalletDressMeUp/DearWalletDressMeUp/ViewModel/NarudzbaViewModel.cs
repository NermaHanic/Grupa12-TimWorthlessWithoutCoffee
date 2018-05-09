using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DearWalletDressMeUp.ViewModel
{
    public class NarudzbaViewModel
    {
        public ICommand provjeraZaPoklon;
        public ICommand obracunCijene;
        public ICommand dodajStavku;

        public NarudzbaViewModel()
        {
            provjeraZaPoklon = new RelayCommand(ProvjeraZaPoklon);
            obracunCijene = new RelayCommand(ObracunajCijenu);
            dodajStavku = new RelayCommand(DodajStavkuNarudzbe);
        }

        public void ProvjeraZaPoklon(object param) { }
        public void ObracunajCijenu(object param) { }
        public void DodajStavkuNarudzbe(object param) { }

    }
}
