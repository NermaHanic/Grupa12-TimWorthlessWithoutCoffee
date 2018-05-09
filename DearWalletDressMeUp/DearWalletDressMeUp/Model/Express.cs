using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Express:Dostava
    {
        private double dodatniTrosak;

        public Express(double dodatniTrosak,string adresaDostave,double cijenaDostave):base(adresaDostave,cijenaDostave)
        {
            this.dodatniTrosak = dodatniTrosak;
        }

        public double DodatniTrosak { get => dodatniTrosak; set => dodatniTrosak = value; }
    }
}
