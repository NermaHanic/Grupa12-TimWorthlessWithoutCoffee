using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Dezen
    {

        private string nazivDezena;
        private string slikaDezena;
        private double cijenaDezena;
        private string sifraDezena;
        //Povezivanje
        private ICollection<OdjevniPredmet> odjevniPredmeti;

        public string NazivDezena { get => nazivDezena; set => nazivDezena = value; }
        public string SlikaDezena { get => slikaDezena; set => slikaDezena = value; }
        public double CijenaDezena { get => cijenaDezena; set => cijenaDezena = value; }
        public string SifraDezena { get => sifraDezena; set => sifraDezena = value; }
        public virtual ICollection<OdjevniPredmet> OdjevniPredmeti { get => odjevniPredmeti; set => odjevniPredmeti = value; }
    }
}