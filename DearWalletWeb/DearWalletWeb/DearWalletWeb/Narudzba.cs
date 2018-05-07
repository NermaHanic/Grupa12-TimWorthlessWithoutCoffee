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

        public string SifraNarudzbe { get => sifraNarudzbe; set => sifraNarudzbe = value; }
        public double UkupnaCijena { get => ukupnaCijena; set => ukupnaCijena = value; }
        public bool ProvjeraZaPoklon()
        {
            if (ukupnaCijena >= 150) return true;
            return false;
        }
        public double ObracunajCijenu() { return 0; }
        public void DodajStavkuNarudzbe() { }
    }
}