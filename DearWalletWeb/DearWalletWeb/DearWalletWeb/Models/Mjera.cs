using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Mjera
    {
        [Required]
        public string MjeraId { get; set; }
        public int DuzinaRuke { get; set; }
        public int DuzinaNoge { get; set; }
        public int ObimStruka { get; set; }
        public int ObimGrudi { get; set; }
        public int SirinaRamena { get; set; }
        //povezivanje
        public virtual ICollection<Kreacija> Kreacija { get; set; }
    }
}