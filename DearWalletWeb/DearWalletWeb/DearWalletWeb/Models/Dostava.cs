using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public abstract class Dostava
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string AdresaDostave { get; set; }
        [Required]
        public double CijenaDostave { get; set; }
        //povezivanje
        public virtual ICollection<Narudzba> Narudzbe { get; set; }
    }
}