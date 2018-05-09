using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Odgovor
    {
        private string tekstOdgovora;
        private Stil pripadniStil;

        public Odgovor(string tekstOdgovora, Stil pripadniStil)
        {
            this.tekstOdgovora = tekstOdgovora;
            this.pripadniStil = pripadniStil;
        }

        public string TekstOdgovora { get => tekstOdgovora; set => tekstOdgovora = value; }
        public Stil PripadniStil { get => pripadniStil; set => pripadniStil = value; }
    }
}
