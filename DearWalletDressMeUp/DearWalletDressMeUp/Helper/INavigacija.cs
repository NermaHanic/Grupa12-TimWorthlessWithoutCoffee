using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Helper
{
    public interface INavigacija
    {
        void Navigiraj(Type sourcePage);
        void Navigiraj(Type sourcePage, object parameter);
        void Nazad();
    }
}

