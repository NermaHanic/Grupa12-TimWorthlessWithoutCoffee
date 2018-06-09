using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DearWalletWebNovi.Models
{
    public class Kreacija
    {
        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdDezen { get; set; }
        //public string Boja { get; set; }
        [Required]
        public string IdOdjevniPredmet { get; set; }
        [Required]
        public string IdKorisnika { get; set; }
        [Required]
        public string Velicina { get; set; }
        public int IdNarudzbe { get; set; }
        /* public virtual OdjevniPredmet OdjevniPredmet { get; set; }
         public virtual Dezen Dezen { get; set; }
         public virtual Korisnik Korisnik { get; set; }*/
    }
}