using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DearWalletWeb.Models;

namespace DearWalletWeb.Models
{
    public class NewContext:DbContext
    {
        public NewContext() : base("MSTable_ConnectionString") { }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Profil> Profil { get; set; }
        public DbSet<Dezen> Dezen { get; set; }
        public DbSet<Dostava> Dostava { get; set; }
        public DbSet<Kreacija> Kreacija { get; set; }
        public DbSet<Materijal> Materijal { get; set; }
        public DbSet<Mjera> Mjera { get; set; }
        public DbSet<Narudzba> Narudzba { get; set; }
        public DbSet<Odgovor> Odgovor { get; set; }
        public DbSet<OdjevniPredmet> OdjevniPredmet { get; set; }
        public DbSet<Poklon> Poklon { get; set; }
        public DbSet<Pitanje> Pitanje { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}