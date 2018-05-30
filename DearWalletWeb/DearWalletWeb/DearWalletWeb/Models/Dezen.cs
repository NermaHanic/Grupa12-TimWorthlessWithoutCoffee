using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Dezen
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string NazivDezena { get; set; }
        //public string SlikaDezena { get; set; }
        [Required]
        public double CijenaDezena { get; set; }
        //Povezivanje
        public virtual ICollection<Kreacija> Kreacije { get; set; }
    }
}