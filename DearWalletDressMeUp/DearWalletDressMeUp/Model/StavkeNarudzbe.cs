using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class StavkeNarudzbe
    {
        private string sifraNarudzbe;
        private string sifraKreacije;
        private int kolicina;

        public StavkeNarudzbe(string sifraNarudzbe, string sifraKreacije, int kolicina)
        {
            this.SifraNarudzbe = sifraNarudzbe;
            this.SifraKreacije = sifraKreacije;
            this.Kolicina = kolicina;
        }

        public string SifraNarudzbe { get => sifraNarudzbe; set => sifraNarudzbe = value; }
        public string SifraKreacije { get => sifraKreacije; set => sifraKreacije = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
    }
}
