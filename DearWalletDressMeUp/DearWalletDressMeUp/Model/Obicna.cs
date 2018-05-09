using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Obicna:Dostava
    {
        public Obicna(string adresaDostave, double cijenaDostave):base(adresaDostave,cijenaDostave)
        {
            this.AdresaDostave = adresaDostave;
            this.CijenaDostave = cijenaDostave;
        }
    }
}
