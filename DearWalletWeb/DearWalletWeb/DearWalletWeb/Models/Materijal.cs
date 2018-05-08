using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Materijal
    {
        public string sifraMaterijala;
        private string nazivMaterijala;
        private double cijenaMaterijala;
        //Povezivanje
        private ICollection<OdjevniPredmet> odjevniPredmeti;

        public string SifraMaterijala { get => sifraMaterijala; set => sifraMaterijala = value; }
        public string NazivMaterijala { get => nazivMaterijala; set => nazivMaterijala = value; }
        public double CijenaMaterijala { get => cijenaMaterijala; set => cijenaMaterijala = value; }
        public virtual ICollection<OdjevniPredmet> OdjevniPredmeti { get => odjevniPredmeti; set => odjevniPredmeti = value; }
    }
}