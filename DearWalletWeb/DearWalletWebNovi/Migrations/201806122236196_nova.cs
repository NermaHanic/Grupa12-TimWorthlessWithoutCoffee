namespace DearWalletWebNovi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nova : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Narudzba", "Cijena", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Narudzba", "Cijena");
        }
    }
}
