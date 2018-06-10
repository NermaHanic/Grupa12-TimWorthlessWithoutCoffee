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
        private string id;
        private double cijenaDezena;

        public Dezen(string nazivDezena, BitmapImage slikaDezena, string sifraDezena, double cijenaDezena)
        {
            this.nazivDezena = nazivDezena;
            this.slikaDezena = slikaDezena;
            this.id = sifraDezena;
            this.cijenaDezena = cijenaDezena;
        }

        public string NazivDezena { get => nazivDezena; set => nazivDezena = value; }
        public BitmapImage SlikaDezena { get => slikaDezena; set => slikaDezena = value; }
        public string Id { get => id; set => id = value; }
        public double CijenaDezena { get => cijenaDezena; set => cijenaDezena = value; }
    }
}
