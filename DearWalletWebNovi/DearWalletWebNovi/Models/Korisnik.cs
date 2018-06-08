using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DearWalletWebNovi.Models
{
    public class Korisnik
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id { get; set; }
        [Required(ErrorMessage = "Ime je obavezno!")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Prezime je obavezno!")]
        public string Prezime { get; set; }
        [Required(ErrorMessage = "Username je obavezan!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Sifra je obavezna!")]
        public string Sifra { get; set; }
        [Required(ErrorMessage = "Email je obavezan!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Adresa je obavezna!")]
        public string Adresa { get; set; }
        [Required(ErrorMessage = "Broj telefona je obavezan!")]
        public string BrojTel { get; set; }
        public string BrojKreditneKartice { get; set; }

        //public virtual ICollection<Kreacija> Kreacije { get; set; }
    }
}