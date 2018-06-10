using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    class Poklon
    {
        private string id;
        private byte[] glasovnaPoruka;
        private string tekstPoruke;

        public Poklon(string id, byte[] glasovnaPoruka)
        {
            this.id = id;
            this.glasovnaPoruka = glasovnaPoruka;
        }

        public Poklon(string id,  string tekstPoruke)
        {
            this.id = id;
            this.tekstPoruke = tekstPoruke;
        }

        public string TekstPoruke { get => tekstPoruke; set => tekstPoruke = value; }
        public string Id { get => id; set => id = value; }

        public void SnimiPoruku() { return; }
    }
}
