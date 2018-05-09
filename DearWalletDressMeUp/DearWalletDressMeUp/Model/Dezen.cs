using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace DearWalletDressMeUp.Model
{
   public class Dezen
    {
        private string nazivDezena;
        private BitmapImage slikaDezena;
        private string sifraDezena;
        private double cijenaDezena;

        public Dezen(string nazivDezena, BitmapImage slikaDezena, string sifraDezena, double cijenaDezena)
        {
            this.nazivDezena = nazivDezena;
            this.slikaDezena = slikaDezena;
            this.sifraDezena = sifraDezena;
            this.cijenaDezena = cijenaDezena;
        }

        public string NazivDezena { get => nazivDezena; set => nazivDezena = value; }
        public BitmapImage SlikaDezena { get => slikaDezena; set => slikaDezena = value; }
        public string SifraDezena { get => sifraDezena; set => sifraDezena = value; }
        public double CijenaDezena { get => cijenaDezena; set => cijenaDezena = value; }
    }
}
