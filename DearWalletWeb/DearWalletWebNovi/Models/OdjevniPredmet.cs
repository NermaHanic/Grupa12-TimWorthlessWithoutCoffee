using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int Id { get; set; }
        [Required]
        public string Naziv { get; set; }
        [Required]
        [DisplayName("Upload file")]
        public string PSlika { get; set; }
        [Required]
        public byte[] Slika { get; set; }
        [Required]
        public double Cijena { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
        // public virtual ICollection<Kreacija> Kreacije { get; set; }
    }
}