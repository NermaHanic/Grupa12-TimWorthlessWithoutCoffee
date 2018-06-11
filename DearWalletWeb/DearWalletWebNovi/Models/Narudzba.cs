using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DearWalletWebNovi.Models
{
    public class Narudzba
    {
        //[Key]
      //[ScaffoldColumn(false)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int IdKorisnika { get; set; }
    }
}