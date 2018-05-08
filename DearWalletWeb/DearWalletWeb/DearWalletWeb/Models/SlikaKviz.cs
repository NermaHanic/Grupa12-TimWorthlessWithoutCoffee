using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class SlikaKviz
    {
        public string SlikaKvizId { get; set; }

        public string KvizId { get; set; }
        public string OdgovorId { get; set; }

        public string PutanjaDoSlike { get; set; }

        public virtual Odgovor Odg { get; set; }
        public virtual Kviz Kviz { get; set; }
    }
}