namespace School.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        PESEL = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        CourseId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Kieruneks",
                c => new
                    {
                        KierunekId = c.Int(nullable: false, identity: true),
                        MiejsceOdlotu = c.String(),
                        MiejscePrzylotu = c.String(),
                        Kieruneks_KierunekId = c.Int(),
                    })
                .PrimaryKey(t => t.KierunekId)
                .ForeignKey("dbo.Kieruneks", t => t.Kieruneks_KierunekId)
                .Index(t => t.Kieruneks_KierunekId);
            
            CreateTable(
                "dbo.Lots",
                c => new
                    {
                        LotId = c.Int(nullable: false, identity: true),
                        NumerLotu = c.String(),
                        DataOdlotu = c.DateTime(nullable: false),
                        DataPrzylotu = c.DateTime(nullable: false),
                        KierunekId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LotId)
                .ForeignKey("dbo.Kieruneks", t => t.KierunekId, cascadeDelete: true)
                .Index(t => t.KierunekId);
            
            CreateTable(
                "dbo.Odprawas",
                c => new
                    {
                        OdprawaId = c.Int(nullable: false, identity: true),
                        NumerBramki = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OdprawaId);
            
            CreateTable(
                "dbo.OdprawaPasazers",
                c => new
                    {
                        OdprawaId = c.Int(nullable: false),
                        Pesel = c.String(nullable: false, maxLength: 128),
                        Bagaz = c.Boolean(nullable: false),
                        WagaBagazu = c.Int(nullable: false),
                        CzasOdprawy = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.OdprawaId, t.Pesel })
                .ForeignKey("dbo.Odprawas", t => t.OdprawaId, cascadeDelete: true)
                .ForeignKey("dbo.Pasazers", t => t.Pesel, cascadeDelete: true)
                .Index(t => t.OdprawaId)
                .Index(t => t.Pesel);
            
            CreateTable(
                "dbo.Pasazers",
                c => new
                    {
                        Pesel = c.String(nullable: false, maxLength: 128),
                        Adres = c.String(),
                        Kraj = c.String(),
                    })
                .PrimaryKey(t => t.Pesel);
            
            CreateTable(
                "dbo.Samolots",
                c => new
                    {
                        SamolotId = c.Int(nullable: false, identity: true),
                        NrSeryjny = c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false),
                        TypId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SamolotId)
                .ForeignKey("dbo.TypSamolotus", t => t.TypId, cascadeDelete: true)
                .Index(t => t.TypId);
            
            CreateTable(
                "dbo.TypSamolotus",
                c => new
                    {
                        TypId = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        IloscMiejsc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TypId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Samolots", "TypId", "dbo.TypSamolotus");
            DropForeignKey("dbo.OdprawaPasazers", "Pesel", "dbo.Pasazers");
            DropForeignKey("dbo.OdprawaPasazers", "OdprawaId", "dbo.Odprawas");
            DropForeignKey("dbo.Lots", "KierunekId", "dbo.Kieruneks");
            DropForeignKey("dbo.Kieruneks", "Kieruneks_KierunekId", "dbo.Kieruneks");
            DropForeignKey("dbo.Students", "CourseId", "dbo.Courses");
            DropIndex("dbo.Samolots", new[] { "TypId" });
            DropIndex("dbo.OdprawaPasazers", new[] { "Pesel" });
            DropIndex("dbo.OdprawaPasazers", new[] { "OdprawaId" });
            DropIndex("dbo.Lots", new[] { "KierunekId" });
            DropIndex("dbo.Kieruneks", new[] { "Kieruneks_KierunekId" });
            DropIndex("dbo.Students", new[] { "CourseId" });
            DropTable("dbo.TypSamolotus");
            DropTable("dbo.Samolots");
            DropTable("dbo.Pasazers");
            DropTable("dbo.OdprawaPasazers");
            DropTable("dbo.Odprawas");
            DropTable("dbo.Lots");
            DropTable("dbo.Kieruneks");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
        }
    }
}
