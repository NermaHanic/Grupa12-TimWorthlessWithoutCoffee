using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class OdjevniPredmet
    {
        private string nazivOdjevnogPredmeta;
        private string slikaOdjevnogPredmeta;
        private double cijenaOdjevnogPredmeta;
        private string barCodeOdjevnogPredmeta;
        //povezivanje
        private Odjel odjel;
        private Stil stil;
        private Dezen dezen;
        private Materijal materijal;
        private DefaultVelicine dvelicina;
        private Mjera mjera;
        private ICollection<Kreacija> kreacije;

        public string NazivOdjevnogPredmeta { get => nazivOdjevnogPredmeta; set => nazivOdjevnogPredmeta = value; }
        public string SlikaOdjevnogPredmeta { get => slikaOdjevnogPredmeta; set => slikaOdjevnogPredmeta = value; }
        public double CijenaOdjevnogPredmeta { get => cijenaOdjevnogPredmeta; set => cijenaOdjevnogPredmeta = value; }
        public string BarCodeOdjevnogPredmeta { get => barCodeOdjevnogPredmeta; set => barCodeOdjevnogPredmeta = value; }

        public virtual Odjel Odjel { get => odjel; set => odjel = value; }
        public virtual Stil Stil { get => stil; set => stil = value; }
        public virtual Dezen Dezen { get => dezen; set => dezen = value; }
        public virtual Materijal Materijal { get => materijal; set => materijal = value; }
        public virtual DefaultVelicine Dvelicina { get => dvelicina; set => dvelicina = value; }
        public virtual Mjera Mjera { get => mjera; set => mjera = value; }
        public virtual ICollection<Kreacija> Kreacije { get => kreacije; set => kreacije = value; }
    }
}