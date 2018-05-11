using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletWeb
{
    public interface IIzmjene
    {
        void IzmjeniIme(string novoIme);
        void IzmjeniPrezime(string novoPrezime);
        void IzmjeniAdresu(string novaAdresa);
        void IzmjeniBrojTelefona(string noviBrojTel);
        void IzmjeniBrojKrediteneKartice(string noviBrojKredKart);
        void IzmjeniSifru(string novaSifra);
        void IzmjeniSliu(string novaSlika);
    }
}
