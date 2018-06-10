using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Snizenje
    {
        private string id;
        private DateTime datumPocetka;
        private DateTime datumZavrsetka;
        private double iznos;

        public Snizenje(string id, DateTime datumPocetka, DateTime datumZavrsetka, double iznos)
        {
            this.id = id;
            this.datumPocetka = datumPocetka;
            this.datumZavrsetka = datumZavrsetka;
            this.iznos = iznos;
        }

        public DateTime DatumPocetka { get => datumPocetka; set => datumPocetka = value; }
        public DateTime DatumZavrsetka { get => datumZavrsetka; set => datumZavrsetka = value; }
        public double Iznos { get => iznos; set => iznos = value; }
        public string Id { get => id; set => id = value; }
    }
}
