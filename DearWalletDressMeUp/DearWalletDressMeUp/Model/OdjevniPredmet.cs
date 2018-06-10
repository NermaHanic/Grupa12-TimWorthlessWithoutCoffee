using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private string id;
        private string naziv;
        private byte[] slika;
        private double cijena;
        private Odjel pripadniOdjel;
        private Stil pripadniStil;

        public OdjevniPredmet() { }
        public OdjevniPredmet(string nazivOdjevnogPredmeta, byte[] slikaOdjevnogPredmeta, double cijenaOdjevnogPredmeta, string barCode, Odjel pripadniOdjel, Stil pripadniStil)
        {
            this.naziv = nazivOdjevnogPredmeta;
            this.slika = slikaOdjevnogPredmeta;
            this.cijena = cijenaOdjevnogPredmeta;
            this.id = barCode;
            this.pripadniOdjel = pripadniOdjel;
            this.pripadniStil = pripadniStil;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public byte[] Slika { get => slika; set => slika = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public string Id { get => id; set => id = value; }
        public Odjel PripadniOdjel { get => pripadniOdjel; set => pripadniOdjel = value; }
        public Stil PripadniStil { get => pripadniStil; set => pripadniStil = value; }
    }
}
