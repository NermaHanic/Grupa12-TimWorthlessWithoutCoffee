using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Admin
    {
        private string username;
        private string sifra;

        public Admin(string username, string sifra)
        {
            this.Username = username;
            this.Sifra = sifra;
        }

        public string Username { get => username; set => username = value; }
        public string Sifra { get => sifra; set => sifra = value; }
    }
}
