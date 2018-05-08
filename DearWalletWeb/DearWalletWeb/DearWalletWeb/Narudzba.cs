using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Narudzba
    {
        private string sifraNarudzbe;
        private double ukupnaCijena;
        //povezivanje
        private Dostava dostava;
        private Poklon poklon;
        private ICollection<StavkeNarudzbe> stavkeNarudzbe;
        private Snizenje snizenje;
        private Profil profil;

        public string SifraNarudzbe { get => sifraNarudzbe; set => sifraNarudzbe = value; }
        public double UkupnaCijena { get => ukupnaCijena; set => ukupnaCijena = value; }
        public virtual Dostava Dostava { get => dostava; set => dostava = value; }
        public virtual Poklon Poklon { get => poklon; set => poklon = value; }
        public virtual ICollection<StavkeNarudzbe> StavkeNarudzbe { get => stavkeNarudzbe; set => stavkeNarudzbe = value; }
        public virtual Snizenje Snizenje { get => snizenje; set => snizenje = value; }
        public virtual Profil Profil { get => profil; set => profil = value; }

        public bool ProvjeraZaPoklon()
        {
            if (ukupnaCijena >= 150) return true;
            return false;
        }
        public double ObracunajCijenu() { return 0; }
        public void DodajStavkuNarudzbe() { }
    }
}