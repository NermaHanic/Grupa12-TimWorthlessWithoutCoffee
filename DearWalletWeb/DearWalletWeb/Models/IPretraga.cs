using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletWeb.Models
{
    interface IPretraga
    {
        void PretragaPoOdjelu();
        void PretragaPoStilu();
        void PetragaPoOdjevnomPredmetu();
        void RandomPretraga();
    }
}
