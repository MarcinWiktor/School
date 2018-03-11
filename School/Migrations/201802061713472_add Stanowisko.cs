namespace School.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStanowisko : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stanowiskoes",
                c => new
                    {
                        StanowiskoId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.StanowiskoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stanowiskoes");
        }
    }
}
