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
        //[Key]
        //[ScaffoldColumn(false)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdDezen { get; set; }
        [Required]
        public int IdOdjevniPredmet { get; set; }
        [Required]
        public int IdKorisnika { get; set; }
        [Required]
        public string Velicina { get; set; }
        public int IdNarudzbe { get; set; }
    }
}