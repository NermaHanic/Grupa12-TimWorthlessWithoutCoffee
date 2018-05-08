using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Odgovor
    {
        private string tekstOdgovora;
        private Stil pripadniStil;

        public string TekstOdgovora { get => tekstOdgovora; set => tekstOdgovora = value; }
        public Stil PripadniStil { get => pripadniStil; set => pripadniStil = value; }
    }
}