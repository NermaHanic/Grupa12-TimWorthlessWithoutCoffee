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
        private string naziv;
        private string slika;
        private double cijena;
        private string id;
        private Odjel pripadniOdjel;
        private Stil pripadniStil;
        private DefaultVelicine defVel;
        private Mjera mjera;

        public OdjevniPredmet() { }
        public OdjevniPredmet(string nazivOdjevnogPredmeta, string slikaOdjevnogPredmeta, double cijenaOdjevnogPredmeta, string barCode, Odjel pripadniOdjel, Stil pripadniStil)
        {
            this.naziv = nazivOdjevnogPredmeta;
            this.slika = slikaOdjevnogPredmeta;
            this.cijena = cijenaOdjevnogPredmeta;
            this.id = barCode;
            this.pripadniOdjel = pripadniOdjel;
            this.pripadniStil = pripadniStil;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Slika { get => slika; set => slika = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public string Id { get => id; set => id = value; }
        public Odjel PripadniOdjel { get => pripadniOdjel; set => pripadniOdjel = value; }
        public Stil PripadniStil { get => pripadniStil; set => pripadniStil = value; }
        public DefaultVelicine DefVel { get => defVel; set => defVel = value; }
        public Mjera Mjera { get => mjera; set => mjera = value; }
    }
}
