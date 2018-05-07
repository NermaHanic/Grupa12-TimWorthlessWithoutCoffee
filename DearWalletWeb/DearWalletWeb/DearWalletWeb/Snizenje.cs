using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Snizenje
    {
        private DateTime datumPocetka;
        private DateTime datumZavrsetka;
        private double iznos;

        public DateTime DatumPocetka { get => datumPocetka; set => datumPocetka = value; }
        public DateTime DatumZavrsetka { get => datumZavrsetka; set => datumZavrsetka = value; }
        public double Iznos { get => iznos; set => iznos = value; }
    }
}