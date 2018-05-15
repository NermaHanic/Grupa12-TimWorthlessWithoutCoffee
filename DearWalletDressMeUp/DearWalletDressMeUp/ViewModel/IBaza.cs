using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.ViewModel
{
    public interface IBaza
    {
        List<T> DobaviIzBaze<T>();
        void UnesiUBazu<T>(T data);
        void UnesiViseUBazu<T>(List<T> data);
    }
}
