namespace School.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addZalogant : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kieruneks", "Kieruneks_KierunekId", "dbo.Kieruneks");
            DropIndex("dbo.Kieruneks", new[] { "Kieruneks_KierunekId" });
            CreateTable(
                "dbo.Zalogants",
                c => new
                    {
                        ZalogantId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StanowiskoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ZalogantId)
                .ForeignKey("dbo.Stanowiskoes", t => t.StanowiskoId, cascadeDelete: true)
                .Index(t => t.StanowiskoId);
            
            AddColumn("dbo.Lots", "Numer", c => c.Int(nullable: false));
            AddColumn("dbo.Lots", "SamolotId", c => c.Int(nullable: false));
            CreateIndex("dbo.Lots", "SamolotId");
            AddForeignKey("dbo.Lots", "SamolotId", "dbo.Samolots", "SamolotId", cascadeDelete: true);
            DropColumn("dbo.Kieruneks", "Kieruneks_KierunekId");
            DropColumn("dbo.Lots", "NumerLotu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lots", "NumerLotu", c => c.String());
            AddColumn("dbo.Kieruneks", "Kieruneks_KierunekId", c => c.Int());
            DropForeignKey("dbo.Zalogants", "StanowiskoId", "dbo.Stanowiskoes");
            DropForeignKey("dbo.Lots", "SamolotId", "dbo.Samolots");
            DropIndex("dbo.Zalogants", new[] { "StanowiskoId" });
            DropIndex("dbo.Lots", new[] { "SamolotId" });
            DropColumn("dbo.Lots", "SamolotId");
            DropColumn("dbo.Lots", "Numer");
            DropTable("dbo.Zalogants");
            CreateIndex("dbo.Kieruneks", "Kieruneks_KierunekId");
            AddForeignKey("dbo.Kieruneks", "Kieruneks_KierunekId", "dbo.Kieruneks", "KierunekId");
        }
    }
}
