using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Odgovor
    {
        [Key]
        public string OdgovorId { get; set; }
        [ForeignKey("Pitanje")]
        public string PitanjeId { get; set; }
        [Required]
        public string TekstOdgovora { get; set; }
        public Stil PripadniStil { get; set; }
        
        public Pitanje Pitanje { get; set; }
    }
}