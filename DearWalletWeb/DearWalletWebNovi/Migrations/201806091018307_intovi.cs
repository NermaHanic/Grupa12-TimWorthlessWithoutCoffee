namespace DearWalletWebNovi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intovi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kreacija", "IdOdjevniPredmet", c => c.Int(nullable: false));
            AlterColumn("dbo.Kreacija", "IdKorisnika", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kreacija", "IdKorisnika", c => c.String(nullable: false));
            AlterColumn("dbo.Kreacija", "IdOdjevniPredmet", c => c.String(nullable: false));
        }
    }
}
