using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Dostava
    {
        public string DostavaId { get; set; }
        public string AdresaDostave { get; set; }
        public double CijenaDostave { get; set; }
        //povezivanje
        public virtual ICollection<Narudzba> Narudzbe { get; set; }
    }
}