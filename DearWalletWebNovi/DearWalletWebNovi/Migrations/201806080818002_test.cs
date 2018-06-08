namespace DearWalletWebNovi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Korisnik");
            AlterColumn("dbo.Korisnik", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Korisnik", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Korisnik");
            AlterColumn("dbo.Korisnik", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Korisnik", "Id");
        }
    }
}
