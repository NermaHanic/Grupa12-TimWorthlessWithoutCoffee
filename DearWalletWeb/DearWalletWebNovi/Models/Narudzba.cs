using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DearWalletWebNovi.Models
{
    [BindableType]
    public class Narudzba
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Id je neophodan!")]
        public int IdKorisnika { get; set; }
        public int Cijena { get; set; }
        
    }
}