using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Poklon
    {

        private string id;
        private string tekstPoruke;
        private const int prag= 150;
        //povezivanje
        private Narudzba narudzba;

        public string Id { get => id; set => id = value; }
        public string TekstPoruke { get => tekstPoruke; set => tekstPoruke = value; }
        public virtual Narudzba Narudzba { get => narudzba; set => narudzba = value; }

        public static int Prag => prag;
        
    }
}