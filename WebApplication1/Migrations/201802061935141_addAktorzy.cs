namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAktorzy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aktorzies",
                c => new
                    {
                        AktorzyId = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        DataUrodzenia = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AktorzyId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Aktorzies");
        }
    }
}
