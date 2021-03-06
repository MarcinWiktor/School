namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class somethingWasChanged : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieGenres",
                c => new
                    {
                        Movie_MovieId = c.Int(nullable: false),
                        Genre_GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_MovieId, t.Genre_GenreId })
                .ForeignKey("dbo.Movies", t => t.Movie_MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.Genre_GenreId, cascadeDelete: true)
                .Index(t => t.Movie_MovieId)
                .Index(t => t.Genre_GenreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieGenres", "Genre_GenreId", "dbo.Genres");
            DropForeignKey("dbo.MovieGenres", "Movie_MovieId", "dbo.Movies");
            DropIndex("dbo.MovieGenres", new[] { "Genre_GenreId" });
            DropIndex("dbo.MovieGenres", new[] { "Movie_MovieId" });
            DropTable("dbo.MovieGenres");
        }
    }
}
