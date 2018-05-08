using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class SlikaKviz
    {
        private string putanjaDoSlike;
        private Odgovor odg;
        private Kviz kviz;

        public string PutanjaDoSlike { get => putanjaDoSlike; set => putanjaDoSlike = value; }
        public virtual Odgovor Odg { get => odg; set => odg = value; }
        public virtual Kviz Kviz { get => kviz; set => kviz = value; }
    }
}