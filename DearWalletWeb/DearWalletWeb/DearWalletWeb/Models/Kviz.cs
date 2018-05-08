using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Kviz
    {
        public string KvizId { get; set; }
        public string PitanjeId { get; set; }
        public string SlikaKvizId { get; set; }

        public virtual Pitanje Pitanje1 { get; set; }
        public virtual Pitanje Pitanje2 { get; set; }
        public virtual Pitanje Pitanje3 { get; set; }
        public virtual ICollection<SlikaKviz> Slike { get; set; }

        public void PrikazRezultata() { }
        public void IspunjavanjeKviza() { }

    }
}