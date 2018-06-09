namespace DearWalletWebNovi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dezen",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
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
                        Id = c.String(nullable: false, maxLength: 128),
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
                        Id = c.String(nullable: false, maxLength: 128),
                        IdDezen = c.String(),
                        Boja = c.String(),
                        IdOdjevniPredmet = c.String(nullable: false),
                        IdKorisnika = c.String(nullable: false),
                        Velicina = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OdjevniPredmet",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Naziv = c.String(nullable: false),
                        Slika = c.Binary(nullable: false),
                        PSlika = c.String(nullable: false),
                        Cijena = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OdjevniPredmet");
            DropTable("dbo.Kreacija");
            DropTable("dbo.Korisnik");
            DropTable("dbo.Dezen");
        }
    }
}
