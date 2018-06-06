using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DearWalletWeb.Models
{
    public class Materijal
    {
        [Required]
        public string MaterijalId { get; set; }
        [Required]
        public string NazivMaterijala { get; set; }
        [Required]
        public double CijenaMaterijala { get; set; }
        //Povezivanje
        public ICollection<Kreacija> Kreacije { get; set; }
    }
}