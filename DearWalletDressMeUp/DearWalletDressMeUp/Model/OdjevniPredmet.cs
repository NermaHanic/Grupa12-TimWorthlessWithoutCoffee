using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public enum Odjel { Muski,Zenski,Djeciji}
    public enum Stil { Casual,Elegant,RockPunkEmo,Vintage,Sport}
    public enum DefaultVelicine { XS,S,M,L,XL}
    public enum Kategorije { Majica,Pantalone,Haljina,Jakna,Suknja}
    public class OdjevniPredmet
    {
        private string nazivOdjevnogPredmeta;
        private string slikaOdjevnogPredmeta;
        private double cijenaOdjevnogPredmeta;
        private string barCode;
        private Odjel pripadniOdjel;

        public OdjevniPredmet(string nazivOdjevnogPredmeta, string slikaOdjevnogPredmeta, double cijenaOdjevnogPredmeta, string barCode, Odjel pripadniOdjel)
        {
            this.nazivOdjevnogPredmeta = nazivOdjevnogPredmeta;
            this.slikaOdjevnogPredmeta = slikaOdjevnogPredmeta;
            this.cijenaOdjevnogPredmeta = cijenaOdjevnogPredmeta;
            this.barCode = barCode;
            this.pripadniOdjel = pripadniOdjel;
        }

        public string NazivOdjevnogPredmeta { get => nazivOdjevnogPredmeta; set => nazivOdjevnogPredmeta = value; }
        public string SlikaOdjevnogPredmeta { get => slikaOdjevnogPredmeta; set => slikaOdjevnogPredmeta = value; }
        public double CijenaOdjevnogPredmeta { get => cijenaOdjevnogPredmeta; set => cijenaOdjevnogPredmeta = value; }
        public string BarCode { get => barCode; set => barCode = value; }
        public Odjel PripadniOdjel { get => pripadniOdjel; set => pripadniOdjel = value; }
    }
}
