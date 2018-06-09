namespace DearWalletWebNovi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nova : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Dezen");
            DropPrimaryKey("dbo.Korisnik");
            DropPrimaryKey("dbo.Kreacija");
            DropPrimaryKey("dbo.OdjevniPredmet");
            AddColumn("dbo.Kreacija", "IdNarudzbe", c => c.Int(nullable: false));
            AlterColumn("dbo.Dezen", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Korisnik", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Kreacija", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Kreacija", "IdDezen", c => c.Int(nullable: false));
            AlterColumn("dbo.OdjevniPredmet", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Dezen", "Id");
            AddPrimaryKey("dbo.Korisnik", "Id");
            AddPrimaryKey("dbo.Kreacija", "Id");
            AddPrimaryKey("dbo.OdjevniPredmet", "Id");
            DropColumn("dbo.Kreacija", "Boja");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kreacija", "Boja", c => c.String());
            DropPrimaryKey("dbo.OdjevniPredmet");
            DropPrimaryKey("dbo.Kreacija");
            DropPrimaryKey("dbo.Korisnik");
            DropPrimaryKey("dbo.Dezen");
            AlterColumn("dbo.OdjevniPredmet", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Kreacija", "IdDezen", c => c.String());
            AlterColumn("dbo.Kreacija", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Korisnik", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Dezen", "Id", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Kreacija", "IdNarudzbe");
            AddPrimaryKey("dbo.OdjevniPredmet", "Id");
            AddPrimaryKey("dbo.Kreacija", "Id");
            AddPrimaryKey("dbo.Korisnik", "Id");
            AddPrimaryKey("dbo.Dezen", "Id");
        }
    }
}
