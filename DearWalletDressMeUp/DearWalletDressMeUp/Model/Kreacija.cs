using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Kreacija
    {
        private byte[] slika;
        private byte[] boja;
        private byte[] dezen = null;
        private double trenutnaCijena;
        private string id;

        public Kreacija(double trenutnaCijena, string sifraKreacije, byte[] slika, byte[] boja, byte[] dezen)
        {
            this.trenutnaCijena = trenutnaCijena;
            this.id = sifraKreacije;
            this.Slika = slika;
            this.dezen = dezen;
            this.boja = boja;
        }

        public double TrenutnaCijena { get => trenutnaCijena; set => trenutnaCijena = value; }
        public string Id { get => id; set => id = value; }
        public byte[] Slika { get => slika; set => slika = value; }
        public byte[] Boja { get => boja; set => boja = value; }
        public byte[] Dezen { get => dezen; set => dezen = value; }

        public double ObracunajCijenu() { return 0; }
    }
}
