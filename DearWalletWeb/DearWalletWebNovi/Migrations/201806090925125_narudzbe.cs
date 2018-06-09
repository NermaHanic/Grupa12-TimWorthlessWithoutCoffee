namespace DearWalletWebNovi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class narudzbe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Narudzba",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdKorisnika = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Narudzba");
        }
    }
}
