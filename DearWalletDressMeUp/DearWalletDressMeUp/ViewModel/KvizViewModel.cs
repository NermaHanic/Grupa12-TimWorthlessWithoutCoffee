using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace DearWalletDressMeUp.ViewModel
{
    public class KvizViewModel
    {
        public ICommand PrikazRezultata;
        public ICommand IspunjavanjeKviza;


        public KvizViewModel()
        {
            PrikazRezultata = new RelayCommand(prikaziRezultat);
            IspunjavanjeKviza = new RelayCommand(ispuniKviz);
        }

        public void prikaziRezultat(object param) { }
        public void ispuniKviz(object param) { }
    }
}
