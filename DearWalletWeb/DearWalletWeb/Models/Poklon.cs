using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DearWalletWeb.Models
{
    public class Poklon
    {
        [Key]
        [ForeignKey("Narudzba")]
        public string NarudzbaId { get; set; }
        public string TekstPoruke { get; set; }
        //public byte[] Snimak { get; set; }

        // public const int Prag = 150;
        //povezivanje
        public virtual Narudzba Narudzba { get; set; }
    }
}