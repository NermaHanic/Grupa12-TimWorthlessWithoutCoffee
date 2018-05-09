using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public abstract class Dostava
    {
        private string adresaDostave;
        private double cijenaDostave;

        public Dostava(string adresaDostave, double cijenaDostave)
        {
            this.AdresaDostave = adresaDostave;
            this.CijenaDostave = cijenaDostave;
        }

        public string AdresaDostave { get => adresaDostave; set => adresaDostave = value; }
        public double CijenaDostave { get => cijenaDostave; set => cijenaDostave = value; }
    }
}
