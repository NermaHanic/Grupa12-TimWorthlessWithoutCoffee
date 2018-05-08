using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class StavkeNarudzbe
    {
        private int kolicina;
        //povezivanje
        private Kreacija kreacija;
        private Narudzba naruzdba;

        public int Kolicina { get => kolicina; set => kolicina = value; }
        public virtual Narudzba Naruzdba { get => naruzdba; set => naruzdba = value; }
        public virtual Kreacija Kreacija { get => kreacija; set => kreacija = value; }
    }
}