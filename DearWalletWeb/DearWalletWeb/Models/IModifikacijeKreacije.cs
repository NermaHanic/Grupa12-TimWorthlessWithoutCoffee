using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletWeb.Models
{
    interface IModifikacijeKreacije
    {
        void DodajOdjevniPredmet(string barCode);
        void UkloniOdjevniPredmet(string barCode);
        void PromijeniDezen(string barCode);
        void PromijeniMaterijal(string barCode);
        void PromijeniBoju(string barCode);
    }
}
