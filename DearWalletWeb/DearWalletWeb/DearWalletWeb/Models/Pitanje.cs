using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Pitanje
    {

        private string tekst;
        private string izabraniOdgovor;

        public string PitanjeId { get; set; }
        public string KvizId { get; set; }
        public string OdgovorId { get; set; }
        

        public string Tekst { get; set; }
        public virtual Odgovor Odg1 { get; set; }
        public virtual Odgovor Odg2 { get; set; }
        public virtual Odgovor Odg3 { get; set; }
        public Odgovor IzabraniOdgovor { get; set; }
        public virtual Kviz Kviz { get; set; }
    }
}