using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DearWalletWebNovi.Models
{
    public class DressMeUpContext:DbContext
    {
        public DressMeUpContext() : base("konektujse") { }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Kreacija> Kreacija { get; set; }
        public DbSet<OdjevniPredmet> OdjevniPredmet { get; set; }
        public DbSet<Dezen> Dezen { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}