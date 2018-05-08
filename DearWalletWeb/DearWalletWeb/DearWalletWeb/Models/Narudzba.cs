using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Narudzba
    {
        public string NarudzbaId { get; set; }
        public string DostavaId { get; set; }
        public double UkupnaCijena { get; set; }
        public string ProfilId { get; set; }
        public string PoklonId { get; set; }
        public string SnizenjeId { get; set; }

        public virtual Dostava Dostava { get; set; }
        public virtual Poklon Poklon { get; set; }
        public virtual ICollection<StavkeNarudzbe> StavkeNarudzbe { get; set; }
        public virtual Snizenje Snizenje { get; set; }
        public virtual Profil Profil { get; set; }

        public bool ProvjeraZaPoklon()
        {
            if (UkupnaCijena >= 150) return true;
            return false;
        }
        public double ObracunajCijenu() { return 0; }
        public void DodajStavkuNarudzbe() { }
    }
}