namespace DearWalletWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class killmenow : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Profils", "ProfilId", "dbo.Korisniks");
            
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropPrimaryKey("dbo.Korisnik");
            RenameColumn(table: "dbo.Profil", name: "ProfilId", newName: "Id");
            RenameIndex(table: "dbo.Profil", name: "IX_ProfilId", newName: "IX_Id");
            RenameTable(name: "dbo.Korisniks", newName: "Korisnik");
            RenameTable(name: "dbo.Profils", newName: "Profil");
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
            
            AddColumn("dbo.Korisnik", "Id", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Korisnik", "Username", c => c.String(nullable: false));
            AddColumn("dbo.Profil", "Narudzba_NarudzbaId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Korisnik", "Ime", c => c.String(nullable: false));
            AlterColumn("dbo.Korisnik", "Prezime", c => c.String(nullable: false));
            AlterColumn("dbo.Korisnik", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Korisnik", "Adresa", c => c.String(nullable: false));
            AlterColumn("dbo.Korisnik", "BrojTel", c => c.String(nullable: false));
            AlterColumn("dbo.Korisnik", "Sifra", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Korisnik", "Id");
            CreateIndex("dbo.Profil", "Narudzba_NarudzbaId");
            AddForeignKey("dbo.Profil", "Narudzba_NarudzbaId", "dbo.Narudzba", "NarudzbaId");
            AddForeignKey("dbo.Profil", "Id", "dbo.Korisnik", "Id");
            DropColumn("dbo.Korisnik", "KorisnikId");
            DropColumn("dbo.Profil", "Slika");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUserLogins");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId });
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId });
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Profil", "Slika", c => c.String());
            AddColumn("dbo.Korisnik", "KorisnikId", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Profil", "Id", "dbo.Korisnik");
            DropForeignKey("dbo.Odgovor", "PitanjeId", "dbo.Pitanje");
            DropForeignKey("dbo.Odgovor", "Pitanje_PitanjeId", "dbo.Pitanje");
            DropForeignKey("dbo.Pitanje", "Od3_OdgovorId", "dbo.Odgovor");
            DropForeignKey("dbo.Pitanje", "Od2_OdgovorId", "dbo.Odgovor");
            DropForeignKey("dbo.Pitanje", "Od1_OdgovorId", "dbo.Odgovor");
            DropForeignKey("dbo.Kreacija", "ProfilId", "dbo.Profil");
            DropForeignKey("dbo.Profil", "Narudzba_NarudzbaId", "dbo.Narudzba");
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
            DropIndex("dbo.Poklon", new[] { "NarudzbaId" });
            DropIndex("dbo.Narudzba", new[] { "DostavaId" });
            DropIndex("dbo.Kreacija", new[] { "Materijal_MaterijalId" });
            DropIndex("dbo.Kreacija", new[] { "NarudzbaId" });
            DropIndex("dbo.Kreacija", new[] { "MjeraId" });
            DropIndex("dbo.Kreacija", new[] { "DezenId" });
            DropIndex("dbo.Kreacija", new[] { "OdjevniPredmetId" });
            DropIndex("dbo.Kreacija", new[] { "ProfilId" });
            DropPrimaryKey("dbo.Korisnik");
            AlterColumn("dbo.Korisnik", "Sifra", c => c.String());
            AlterColumn("dbo.Korisnik", "BrojTel", c => c.String());
            AlterColumn("dbo.Korisnik", "Adresa", c => c.String());
            AlterColumn("dbo.Korisnik", "Email", c => c.String());
            AlterColumn("dbo.Korisnik", "Prezime", c => c.String());
            AlterColumn("dbo.Korisnik", "Ime", c => c.String());
            DropColumn("dbo.Profil", "Narudzba_NarudzbaId");
            DropColumn("dbo.Korisnik", "Username");
            DropColumn("dbo.Korisnik", "Id");
            DropTable("dbo.Pitanje");
            DropTable("dbo.Odgovor");
            DropTable("dbo.OdjevniPredmet");
            DropTable("dbo.Poklon");
            DropTable("dbo.Dostava");
            DropTable("dbo.Narudzba");
            DropTable("dbo.Mjera");
            DropTable("dbo.Materijal");
            DropTable("dbo.Kreacija");
            DropTable("dbo.Dezen");
            AddPrimaryKey("dbo.Korisnik", "KorisnikId");
            RenameIndex(table: "dbo.Profil", name: "IX_Id", newName: "IX_ProfilId");
            RenameColumn(table: "dbo.Profil", name: "Id", newName: "ProfilId");
            CreateIndex("dbo.AspNetUserLogins", "UserId");
            CreateIndex("dbo.AspNetUserClaims", "UserId");
            CreateIndex("dbo.AspNetUsers", "UserName", unique: true, name: "UserNameIndex");
            CreateIndex("dbo.AspNetUserRoles", "RoleId");
            CreateIndex("dbo.AspNetUserRoles", "UserId");
            CreateIndex("dbo.AspNetRoles", "Name", unique: true, name: "RoleNameIndex");
            AddForeignKey("dbo.Profils", "ProfilId", "dbo.Korisniks", "KorisnikId");
            AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.Profil", newName: "Profils");
            RenameTable(name: "dbo.Korisnik", newName: "Korisniks");
        }
    }
}
