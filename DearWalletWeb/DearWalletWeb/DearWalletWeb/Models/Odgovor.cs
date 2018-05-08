using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Odgovor
    {

        public string OdgovorId { get; set; }
        public string TekstOdgovora { get; set; }
        public Stil PripadniStil { get; set; }

        public string SlikaKvizId { get; set; }
        public string PitanjeId { get; set; }

        public virtual Pitanje pitanje { get; set; }
        public virtual SlikaKviz slika { get; set; }

    }
}