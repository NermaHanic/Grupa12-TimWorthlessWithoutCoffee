namespace DearWalletWebNovi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class meh : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dezen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false),
                        Slika = c.Binary(nullable: false),
                        PSlika = c.String(nullable: false),
                        Cijena = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Korisnik",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(nullable: false),
                        Prezime = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Sifra = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Adresa = c.String(nullable: false),
                        BrojTel = c.String(nullable: false),
                        BrojKreditneKartice = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kreacija",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdDezen = c.Int(nullable: false),
                        IdOdjevniPredmet = c.Int(nullable: false),
                        IdKorisnika = c.Int(nullable: false),
                        Velicina = c.String(nullable: false),
                        IdNarudzbe = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Narudzba",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdKorisnika = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OdjevniPredmet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false),
                        PSlika = c.String(nullable: false),
                        Slika = c.Binary(nullable: false),
                        Cijena = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OdjevniPredmet");
            DropTable("dbo.Narudzba");
            DropTable("dbo.Kreacija");
            DropTable("dbo.Korisnik");
            DropTable("dbo.Dezen");
        }
    }
}
