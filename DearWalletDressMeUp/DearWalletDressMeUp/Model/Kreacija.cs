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
        private string id;

        public Kreacija(double trenutnaCijena, string sifraKreacije)
        {
            this.trenutnaCijena = trenutnaCijena;
            this.id = sifraKreacije;
        }

        public double TrenutnaCijena { get => trenutnaCijena; set => trenutnaCijena = value; }
        public string Id { get => id; set => id = value; }
        public double ObracunajCijenu() { return 0; }
    }
}
