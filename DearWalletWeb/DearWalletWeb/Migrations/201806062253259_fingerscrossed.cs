namespace DearWalletWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fingerscrossed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dezen",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        NazivDezena = c.String(nullable: false),
                        CijenaDezena = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kreacija",
                c => new
                    {
                        KreacijaId = c.String(nullable: false, maxLength: 128),
                        ProfilId = c.String(maxLength: 128),
                        OdjevniPredmetId = c.String(maxLength: 128),
                        DezenId = c.String(maxLength: 128),
                        MjeraId = c.String(maxLength: 128),
                        NarudzbaId = c.String(maxLength: 128),
                        defVel = c.Int(nullable: false),
                        TrenutnaCijena = c.Double(nullable: false),
                        Materijal_MaterijalId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.KreacijaId)
                .ForeignKey("dbo.Dezen", t => t.DezenId)
                .ForeignKey("dbo.Materijal", t => t.Materijal_MaterijalId)
                .ForeignKey("dbo.Mjera", t => t.MjeraId)
                .ForeignKey("dbo.Narudzba", t => t.NarudzbaId)
                .ForeignKey("dbo.OdjevniPredmet", t => t.OdjevniPredmetId)
                .ForeignKey("dbo.Profil", t => t.ProfilId)
                .Index(t => t.ProfilId)
                .Index(t => t.OdjevniPredmetId)
                .Index(t => t.DezenId)
                .Index(t => t.MjeraId)
                .Index(t => t.NarudzbaId)
                .Index(t => t.Materijal_MaterijalId);
            
            CreateTable(
                "dbo.Materijal",
                c => new
                    {
                        MaterijalId = c.String(nullable: false, maxLength: 128),
                        NazivMaterijala = c.String(nullable: false),
                        CijenaMaterijala = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.MaterijalId);
            
            CreateTable(
                "dbo.Mjera",
                c => new
                    {
                        MjeraId = c.String(nullable: false, maxLength: 128),
                        DuzinaRuke = c.Int(nullable: false),
                        DuzinaNoge = c.Int(nullable: false),
                        ObimStruka = c.Int(nullable: false),
                        ObimGrudi = c.Int(nullable: false),
                        SirinaRamena = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MjeraId);
            
            CreateTable(
                "dbo.Narudzba",
                c => new
                    {
                        NarudzbaId = c.String(nullable: false, maxLength: 128),
                        DostavaId = c.String(maxLength: 128),
                        UkupnaCijena = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.NarudzbaId)
                .ForeignKey("dbo.Dostava", t => t.DostavaId)
                .Index(t => t.DostavaId);
            
            CreateTable(
                "dbo.Dostava",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        AdresaDostave = c.String(nullable: false),
                        CijenaDostave = c.Double(nullable: false),
                        DodatniTrosak = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Poklon",
                c => new
                    {
                        NarudzbaId = c.String(nullable: false, maxLength: 128),
                        TekstPoruke = c.String(),
                    })
                .PrimaryKey(t => t.NarudzbaId)
                .ForeignKey("dbo.Narudzba", t => t.NarudzbaId)
                .Index(t => t.NarudzbaId);
            
            CreateTable(
                "dbo.OdjevniPredmet",
                c => new
                    {
                        OdjevniPredmetId = c.String(nullable: false, maxLength: 128),
                        NazivOdjevnogPredmeta = c.String(nullable: false),
                        CijenaOdjevnogPredmeta = c.Double(nullable: false),
                        Odjel = c.Int(nullable: false),
                        Stil = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OdjevniPredmetId);
            
            CreateTable(
                "dbo.Profil",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Narudzba_NarudzbaId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Korisnik", t => t.Id)
                .ForeignKey("dbo.Narudzba", t => t.Narudzba_NarudzbaId)
                .Index(t => t.Id)
                .Index(t => t.Narudzba_NarudzbaId);
            
            CreateTable(
                "dbo.Korisnik",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Username = c.String(nullable: false),
                        Ime = c.String(nullable: false),
                        Prezime = c.String(nullable: false),
                        Sifra = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Adresa = c.String(nullable: false),
                        BrojTel = c.String(nullable: false),
                        BrojKreditneKartice = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Odgovor",
                c => new
                    {
                        OdgovorId = c.String(nullable: false, maxLength: 128),
                        PitanjeId = c.String(maxLength: 128),
                        TekstOdgovora = c.String(nullable: false),
                        PripadniStil = c.Int(nullable: false),
                        Pitanje_PitanjeId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OdgovorId)
                .ForeignKey("dbo.Pitanje", t => t.Pitanje_PitanjeId)
                .ForeignKey("dbo.Pitanje", t => t.PitanjeId)
                .Index(t => t.PitanjeId)
                .Index(t => t.Pitanje_PitanjeId);
            
            CreateTable(
                "dbo.Pitanje",
                c => new
                    {
                        PitanjeId = c.String(nullable: false, maxLength: 128),
                        Tekst = c.String(),
                        Od1_OdgovorId = c.String(maxLength: 128),
                        Od2_OdgovorId = c.String(maxLength: 128),
                        Od3_OdgovorId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PitanjeId)
                .ForeignKey("dbo.Odgovor", t => t.Od1_OdgovorId)
                .ForeignKey("dbo.Odgovor", t => t.Od2_OdgovorId)
                .ForeignKey("dbo.Odgovor", t => t.Od3_OdgovorId)
                .Index(t => t.Od1_OdgovorId)
                .Index(t => t.Od2_OdgovorId)
                .Index(t => t.Od3_OdgovorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Odgovor", "PitanjeId", "dbo.Pitanje");
            DropForeignKey("dbo.Odgovor", "Pitanje_PitanjeId", "dbo.Pitanje");
            DropForeignKey("dbo.Pitanje", "Od3_OdgovorId", "dbo.Odgovor");
            DropForeignKey("dbo.Pitanje", "Od2_OdgovorId", "dbo.Odgovor");
            DropForeignKey("dbo.Pitanje", "Od1_OdgovorId", "dbo.Odgovor");
            DropForeignKey("dbo.Kreacija", "ProfilId", "dbo.Profil");
            DropForeignKey("dbo.Profil", "Narudzba_NarudzbaId", "dbo.Narudzba");
            DropForeignKey("dbo.Profil", "Id", "dbo.Korisnik");
            DropForeignKey("dbo.Kreacija", "OdjevniPredmetId", "dbo.OdjevniPredmet");
            DropForeignKey("dbo.Kreacija", "NarudzbaId", "dbo.Narudzba");
            DropForeignKey("dbo.Poklon", "NarudzbaId", "dbo.Narudzba");
            DropForeignKey("dbo.Narudzba", "DostavaId", "dbo.Dostava");
            DropForeignKey("dbo.Kreacija", "MjeraId", "dbo.Mjera");
            DropForeignKey("dbo.Kreacija", "Materijal_MaterijalId", "dbo.Materijal");
            DropForeignKey("dbo.Kreacija", "DezenId", "dbo.Dezen");
            DropIndex("dbo.Pitanje", new[] { "Od3_OdgovorId" });
            DropIndex("dbo.Pitanje", new[] { "Od2_OdgovorId" });
            DropIndex("dbo.Pitanje", new[] { "Od1_OdgovorId" });
            DropIndex("dbo.Odgovor", new[] { "Pitanje_PitanjeId" });
            DropIndex("dbo.Odgovor", new[] { "PitanjeId" });
            DropIndex("dbo.Profil", new[] { "Narudzba_NarudzbaId" });
            DropIndex("dbo.Profil", new[] { "Id" });
            DropIndex("dbo.Poklon", new[] { "NarudzbaId" });
            DropIndex("dbo.Narudzba", new[] { "DostavaId" });
            DropIndex("dbo.Kreacija", new[] { "Materijal_MaterijalId" });
            DropIndex("dbo.Kreacija", new[] { "NarudzbaId" });
            DropIndex("dbo.Kreacija", new[] { "MjeraId" });
            DropIndex("dbo.Kreacija", new[] { "DezenId" });
            DropIndex("dbo.Kreacija", new[] { "OdjevniPredmetId" });
            DropIndex("dbo.Kreacija", new[] { "ProfilId" });
            DropTable("dbo.Pitanje");
            DropTable("dbo.Odgovor");
            DropTable("dbo.Korisnik");
            DropTable("dbo.Profil");
            DropTable("dbo.OdjevniPredmet");
            DropTable("dbo.Poklon");
            DropTable("dbo.Dostava");
            DropTable("dbo.Narudzba");
            DropTable("dbo.Mjera");
            DropTable("dbo.Materijal");
            DropTable("dbo.Kreacija");
            DropTable("dbo.Dezen");
        }
    }
}
