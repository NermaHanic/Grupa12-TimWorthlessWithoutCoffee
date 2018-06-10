using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
   public class Pitanje
    {
        private string tekstPitanja;
        private Odgovor izabraniOdgovor;
        private string id;

        public Pitanje(string id, string tekstPitanja, Odgovor izabraniOdgovor)
        {
            this.Id = id;
            this.TekstPitanja = tekstPitanja;
            this.IzabraniOdgovor = izabraniOdgovor;
        }

        public string TekstPitanja { get => tekstPitanja; set => tekstPitanja = value; }
        public Odgovor IzabraniOdgovor { get => izabraniOdgovor; set => izabraniOdgovor = value; }
        public string Id { get => id; set => id = value; }
    }
}
