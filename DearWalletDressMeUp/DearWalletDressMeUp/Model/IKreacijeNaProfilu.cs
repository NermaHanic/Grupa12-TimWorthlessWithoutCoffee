using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    interface IKreacijeNaProfilu
    {
        void DodajKreaciju(string idKreacije);
        void ObrisiKreaciju(string idKreacije);
        

    }
}
