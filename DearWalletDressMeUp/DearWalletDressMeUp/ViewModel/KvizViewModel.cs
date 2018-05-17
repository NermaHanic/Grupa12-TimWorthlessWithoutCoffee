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
    public class KvizViewModel
    {
        public ICommand PrikazRezultata;
        public ICommand IspunjavanjeKviza;


        public KvizViewModel()
        {
<<<<<<< HEAD
            PrikazRezultata = new RelayCommand<object>(PrikaziRezultat);
            IspunjavanjeKviza = new RelayCommand<object>(IspuniKviz);
=======
            PrikazRezultata = new RelayCommand<object>(prikaziRezultat);
            IspunjavanjeKviza = new RelayCommand<object>(ispuniKviz);
>>>>>>> fdfdfd4ab3669d3bcb126d8aacfaccfdbfb2d990
        }

        public void PrikaziRezultat(object param) { }
        public void IspuniKviz(object param) { }
    }
}
