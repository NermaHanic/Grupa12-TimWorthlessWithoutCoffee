using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Materijal
    {
        public string MaterijalId { get; set; }
        public string NazivMaterijala { get; set; }
        public double CijenaMaterijala { get; set; }
        //Povezivanje
        public ICollection<OdjevniPredmet> OdjevniPredmeti { get; set; }
    }
}