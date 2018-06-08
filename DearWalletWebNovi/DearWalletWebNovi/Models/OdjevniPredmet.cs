using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DearWalletWebNovi.Models
{
    public class OdjevniPredmet
    {
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id {get; set;}
        [Required]
        public string Naziv { get; set; }
       [Required]
        public byte[] Slika { get; set; }
        [Required]
        public string PSlika { get; set; }
        [Required]
        public double Cijena { get; set; }

       // public virtual ICollection<Kreacija> Kreacije { get; set; }
    }
}