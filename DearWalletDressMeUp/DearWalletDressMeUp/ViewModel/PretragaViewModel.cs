using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DearWalletDressMeUp.Helper;
using DearWalletDressMeUp.Model;
using System.Windows.Input;

namespace DearWalletDressMeUp.ViewModel
{
    public class PretragaViewModel:IPretraga
    {
       /* public ICommand pretragaPoOdjelu;
        public ICommand pretragaPoStilu;
        public ICommand pretragaPoPredmetu;
        public ICommand rendomPretraga;
        public PretragaViewModel()
        {
            pretragaPoOdjelu = new RelayCommand<object>(PretragaPoOdjelu);
        }*/
        public void PretragaPoOdjelu() { }
        public void PretragaPoStilu() { }
        public void PretragaPoOdjevnomPredmetu() { }
        public void RandomPretraga() { }
    }
}
