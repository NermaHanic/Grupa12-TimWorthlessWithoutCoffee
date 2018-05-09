using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Narudzba
    {
        private string sifraNarudzbe;
        private double ukupnaCijena;
        private List<StavkeNarudzbe> stavkeNarudzbe;

        public Narudzba(string sifraNarudzbe, double ukupnaCijena, List<StavkeNarudzbe> stavkeNarudzbe)
        {
            this.sifraNarudzbe = sifraNarudzbe;
            this.ukupnaCijena = ukupnaCijena;
            this.stavkeNarudzbe = stavkeNarudzbe;
        }

        public string SifraNarudzbe { get => sifraNarudzbe; set => sifraNarudzbe = value; }
        public double UkupnaCijena { get => ukupnaCijena; set => ukupnaCijena = value; }
        public List<StavkeNarudzbe> StavkeNarudzbe { get => stavkeNarudzbe; set => stavkeNarudzbe = value; }

        public double ObracunajCijenu() { return 0; }
        public bool ProvjeraZaPoklon() { return true; }
        public void DodajStavkeNarudzbe(StavkeNarudzbe stavka) { }
    }
}
