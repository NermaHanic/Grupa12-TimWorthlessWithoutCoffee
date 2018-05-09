using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Kreacija
    {
        private double trenutnaCijena;
        private string sifraKreacije;

        public Kreacija(double trenutnaCijena, string sifraKreacije)
        {
            this.trenutnaCijena = trenutnaCijena;
            this.sifraKreacije = sifraKreacije;
        }

        public double TrenutnaCijena { get => trenutnaCijena; set => trenutnaCijena = value; }
        public string SifraKreacije { get => sifraKreacije; set => sifraKreacije = value; }
        public double ObracunajCijenu() { return 0; }
    }
}
