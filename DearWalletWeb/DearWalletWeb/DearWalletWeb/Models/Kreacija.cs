using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Kreacija
    {
        public string KreacijaId { get; set; }
        public string ProfilId { get; set; }
        public string OdjevniPredmetId { get; set; }
        public string StavkeNarudzbeId { get; set; }
        public double TrenutnaCijena { get; set; }
        //povezivanje
        public virtual StavkeNarudzbe StavkaNarudzbe { get; set; }
        public virtual OdjevniPredmet OdjevniPredmet { get; set; }
        public virtual Profil Profil { get; set; }

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