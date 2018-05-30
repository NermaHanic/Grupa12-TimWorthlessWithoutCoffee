using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Kreacija
    {
        [Required]
        public string KreacijaId { get; set; }
        [ForeignKey("Profil")]
        public string ProfilId { get; set; }
        [ForeignKey("OdjevniPredmet")]
        public string OdjevniPredmetId { get; set; }
        [ForeignKey("Dezen")]
        public string DezenId { get; set; }
        [ForeignKey("Mjera")]
        public string MjeraId { get; set; }
        [ForeignKey("Narudzba")]
        public string NarudzbaId { get; set; }
        public DefaultVelicine defVel { get; set; }
        [Required]
        public double TrenutnaCijena { get; set; }
        //povezivanje
        public virtual OdjevniPredmet OdjevniPredmet { get; set; }
        public virtual Profil Profil { get; set; }
        public virtual Dezen Dezen {get; set;}
        public virtual Mjera Mjera { get; set; }
        public virtual Materijal Materijal { get; set; }
        public virtual Narudzba Narudzba { get; set; }

        public double ObracunajCijenu()
        {
            return 0;
        }

        void DodajOdjevniPredmet(string barCode) { }
        void UkloniOdjevniPredmet(string barCode) { }
        void PromijeniDezen(string barCode) { }
        void PromijeniMaterijal(string barCode) { }
        void PromijeniBoju(string barCode) { }

    }
}