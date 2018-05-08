using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Poklon
    {

        public string PoklonId { get; set; }
        public string TekstPoruke { get; set; }
        public const int Prag = 150;
        //povezivanje
        public virtual Narudzba Narudzba { get; set; }

    }
}