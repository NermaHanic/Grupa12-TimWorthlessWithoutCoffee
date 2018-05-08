using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class OdjevniPredmet
    {

        public string OdjevniPredmetId { get; set; }
        public string KreacijaId { get; set; }
        public string MaterijalId { get; set; }
        public string MjeraId { get; set; }
        public string DezenId { get; set; }
        public string NazivOdjevnogPredmeta { get; set; }
        public string SlikaOdjevnogPredmeta { get; set; }
        public double CijenaOdjevnogPredmeta { get; set; }

        //povezivanje
        public virtual Odjel Odjel { get; set; }
        public virtual Stil Stil { get; set; }
        public virtual Dezen Dezen { get; set; }
        public virtual Materijal Materijal { get; set; }
        public virtual DefaultVelicine Dvelicina { get; set; }
        public virtual Mjera Mjera { get; set; }
        public virtual ICollection<Kreacija> Kreacije { get; set; }
    }
}