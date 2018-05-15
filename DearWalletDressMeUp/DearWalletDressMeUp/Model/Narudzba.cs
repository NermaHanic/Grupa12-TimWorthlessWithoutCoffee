using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Narudzba
    {
        private string id;
        private double ukupnaCijena;
        private List<StavkeNarudzbe> stavkeNarudzbe;
        private Dostava dostava;

        public Narudzba(string sifraNarudzbe, double ukupnaCijena, List<StavkeNarudzbe> stavkeNarudzbe, Dostava dostava)
        {
            this.id = sifraNarudzbe;
            this.ukupnaCijena = ukupnaCijena;
            this.stavkeNarudzbe = stavkeNarudzbe;
            this.dostava = dostava;
        }

        public string Id { get => id; set => id = value; }
        public double UkupnaCijena { get => ukupnaCijena; set => ukupnaCijena = value; }
        public List<StavkeNarudzbe> StavkeNarudzbe { get => stavkeNarudzbe; set => stavkeNarudzbe = value; }
        public Dostava Dostava { get => dostava; set => dostava = value; }

        public double ObracunajCijenu() { return 0; }
        public bool ProvjeraZaPoklon() { return true; }
        public void DodajStavkeNarudzbe(StavkeNarudzbe stavka) { }
    }
}
