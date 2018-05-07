using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Dostava
    {
        private string id;
        private string adresaDostave;
        private double cijenaDostave;

        public string Id { get => id; set => id = value; }
        public string AdresaDostave { get => adresaDostave; set => adresaDostave = value; }
        public double CijenaDostave { get => cijenaDostave; set => cijenaDostave = value; }
    }
}