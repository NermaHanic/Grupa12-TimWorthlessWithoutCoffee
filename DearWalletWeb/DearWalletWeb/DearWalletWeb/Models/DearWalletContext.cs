using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;

namespace DearWalletWeb.Models
{
    public class DearWalletContext:DbContext
    {
        public DearWalletContext() : base("DearWalletContext") { }
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer<DearWalletContext>(null);
            base.OnModelCreating(modelBuilder);
        }
        public static DearWalletContext Create()
        {
            return new DearWalletContext();
        }

        public System.Data.Entity.DbSet<DearWalletWeb.Poklon> Poklons { get; set; }

        public System.Data.Entity.DbSet<DearWalletWeb.Pitanje> Pitanjes { get; set; }
    }
}