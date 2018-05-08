using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Kviz
    {
        private Pitanje pitanje1;
        private Pitanje pitanje2;
        private Pitanje pitanje3;
        private ICollection<SlikaKviz> slike; 

        public virtual Pitanje Pitanje1 { get => pitanje1; set => pitanje1 = value; }
        public virtual Pitanje Pitanje2 { get => pitanje2; set => pitanje2 = value; }
        public virtual Pitanje Pitanje3 { get => pitanje3; set => pitanje3 = value; }
        public virtual ICollection<SlikaKviz> Slike { get => slike; set => slike = value; }

        public void PrikazRezultata() { }
        public void IspunjavanjeKviza() { }

    }
}