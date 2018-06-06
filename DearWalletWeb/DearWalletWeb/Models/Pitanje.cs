using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb.Models
{
    public class Pitanje
    {
        public string PitanjeId { get; set; }
        public string Tekst { get; set; }

        public Odgovor Od1 { get; set; }
        public Odgovor Od2 { get; set; }
        public Odgovor Od3 { get; set; }

        public virtual ICollection<Odgovor> Odgovor { get; set; }
    }
}