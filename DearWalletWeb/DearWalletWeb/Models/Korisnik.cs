using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DearWalletWeb.Models
{
    public class Korisnik
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public string Sifra { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        public string BrojTel { get; set; }
        public string BrojKreditneKartice { get; set; }

        public virtual Profil Profil { get; set; }
    }
}