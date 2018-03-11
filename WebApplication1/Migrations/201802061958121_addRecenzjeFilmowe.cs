namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRecenzjeFilmowe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RecenzjeFilmowes",
                c => new
                    {
                        RecenzjeFilmoweId = c.Int(nullable: false, identity: true),
                        Score = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.RecenzjeFilmoweId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RecenzjeFilmowes");
        }
    }
}
