using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DearWalletWeb.Models
{
    public class Narudzba
    {
        [Required]
        public string NarudzbaId { get; set; }
        [ForeignKey("Dostava")]
        public string DostavaId { get; set; }
        [Required]
        public double UkupnaCijena { get; set; }

        public virtual Dostava Dostava { get; set; }
        public virtual Poklon Poklon { get; set; }

        public virtual ICollection<Kreacija> Kreacije { get; set; }

        public bool ProvjeraZaPoklon()
        {
            if (UkupnaCijena >= 150) return true;
            return false;
        }
        public double ObracunajCijenu() { return 0; }
        public void DodajStavkuNarudzbe() { }
    }
}