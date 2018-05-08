using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class StavkeNarudzbe
    {
        public string StavkeNarudzbeId { get; set; }
        public int Kolicina { get; set; }
        public string NarudzbaId { get; set; }
        public string KreacijaId { get; set; }

        public virtual Narudzba Naruzdba { get; set; }
        public virtual Kreacija Kreacija { get; set; }
    }
}