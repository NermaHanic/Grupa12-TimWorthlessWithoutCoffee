using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class SlikaKviz
    {
        private string putanjaDoSlike;

        public SlikaKviz(string putanjaDoSlike)
        {
            this.PutanjaDoSlike = putanjaDoSlike;
        }

        public string PutanjaDoSlike { get => putanjaDoSlike; set => putanjaDoSlike = value; }
    }
}
