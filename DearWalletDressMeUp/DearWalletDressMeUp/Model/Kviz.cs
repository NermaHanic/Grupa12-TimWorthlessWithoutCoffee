using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Kviz
    {
        private List<Pitanje> listaPitanja;
        private List<SlikaKviz> listaSlika;

        public List<Pitanje> ListaPitanja { get => listaPitanja; set => listaPitanja = value; }
        public List<SlikaKviz> ListaSlika { get => listaSlika; set => listaSlika = value; }

        public Kviz(List<Pitanje> listaPitanja, List<SlikaKviz> listaSlika)
        {
            this.ListaPitanja = listaPitanja;
            this.ListaSlika = listaSlika;
        }

        public void PrikazRezultata() { return; }
        public void IspunjavanjeKviza() { }

    }
}
