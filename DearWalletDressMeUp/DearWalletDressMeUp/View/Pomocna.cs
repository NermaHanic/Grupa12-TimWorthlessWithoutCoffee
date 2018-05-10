using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp
{
    public static class Pomocna
    {
        public static string DodjelaUsername(string ime, string prezime)
        {
            return ime.ToLower()[0] + prezime.ToLower();

        }
    }
}
