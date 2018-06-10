using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Odgovor
    {
        private string id;
        private string tekstOdgovora;
        private Stil pripadniStil;

        public Odgovor(string id, string tekstOdgovora, Stil pripadniStil)
        {
            this.Id = id;
            this.tekstOdgovora = tekstOdgovora;
            this.pripadniStil = pripadniStil;
        }

        public string TekstOdgovora { get => tekstOdgovora; set => tekstOdgovora = value; }
        public Stil PripadniStil { get => pripadniStil; set => pripadniStil = value; }
        public string Id { get => id; set => id = value; }
    }
}
