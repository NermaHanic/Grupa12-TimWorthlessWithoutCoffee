using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace DearWalletDressMeUp.Model
{
    public static class ID<T>
    {
        public static async Task<string> DodjelaID(IMobileServiceTable<T> tabela)
        {
            return ((await tabela.ToListAsync()).Count() + 1).ToString();
        }
    }
}
