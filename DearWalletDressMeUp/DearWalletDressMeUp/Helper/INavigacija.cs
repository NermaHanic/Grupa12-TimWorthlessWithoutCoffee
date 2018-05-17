using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System;
>>>>>>> fdfdfd4ab3669d3bcb126d8aacfaccfdbfb2d990
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

