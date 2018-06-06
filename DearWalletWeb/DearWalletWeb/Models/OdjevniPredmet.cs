using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DearWalletWeb.Models
{
    public enum Stil { Casual, Vintage, Elegant, Rock, Sport}
    public enum DefaultVelicine { XS, S, M, L, XL}
    public enum Odjel { Muski, Zenski, Djeciji}

    public class OdjevniPredmet
    {
        [Required]
        public string OdjevniPredmetId { get; set; }
        [Required]
        public string NazivOdjevnogPredmeta { get; set; }
        //public string SlikaOdjevnogPredmeta { get; set; }
        [Required]
        public double CijenaOdjevnogPredmeta { get; set; }

        //povezivanje
        public virtual Odjel Odjel { get; set; }
        public virtual Stil Stil { get; set; }
        public virtual ICollection<Kreacija> Kreacija { get; set; }
    }
}