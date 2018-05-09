using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Materijal
    {
        private string nazivMaterijala;
        private double cijenaMaterijala;
        private string sifraMaterijala;

        public Materijal(string nazivMaterijala, double cijenaMaterijala, string sifraMaterijala)
        {
            this.nazivMaterijala = nazivMaterijala;
            this.cijenaMaterijala = cijenaMaterijala;
            this.sifraMaterijala = sifraMaterijala;
        }

        public string NazivMaterijala { get => nazivMaterijala; set => nazivMaterijala = value; }
        public double CijenaMaterijala { get => cijenaMaterijala; set => cijenaMaterijala = value; }
        public string SifraMaterijala { get => sifraMaterijala; set => sifraMaterijala = value; }
    }
}
