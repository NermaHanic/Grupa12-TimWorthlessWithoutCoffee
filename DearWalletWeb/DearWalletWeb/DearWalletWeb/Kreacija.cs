using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Kreacija
    {
        private string sifraKreacije;
        private double trenutnaCijena;
        //povezivanje
        private ICollection<OdjevniPredmet> odjevniPredmeti;
        private StavkeNarudzbe stavkaNarudzbe;
        private Profil profil;

        public string SifraKreacije { get => sifraKreacije; set => sifraKreacije = value; }
        public double TrenutnaCijena { get => trenutnaCijena; set => trenutnaCijena = value; }
        public virtual ICollection<OdjevniPredmet> OdjevniPredmeti { get => odjevniPredmeti; set => odjevniPredmeti = value; }
        public virtual StavkeNarudzbe StavkaNarudzbe { get => stavkaNarudzbe; set => stavkaNarudzbe = value; }
        public virtual Profil Profil { get => profil; set => profil = value; }

        public double ObracunajCijenu()
        {
            return 0;
        }

        void DodajOdjevniPredmet(string barCode) { }
        void UkloniOdjevniPredmet(string barCode) { }
        void PromijeniDezen(string barCode) { }
        void PromijeniMaterijal(string barCode) { }
        void PromijeniBoju(string barCode) { }


    }
}