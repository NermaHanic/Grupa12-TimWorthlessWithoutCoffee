using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Dezen
    {
        public string DezenId { get; set; }
        public string NazivDezena { get; set; }
        public string SlikaDezena { get; set; }
        public double CijenaDezena { get; set; }

        //Povezivanje
        public virtual ICollection<OdjevniPredmet> OdjevniPredmeti { get; set; }
    }
}