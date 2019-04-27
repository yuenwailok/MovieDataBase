namespace WebApplication7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActorAndUserRatingAndDescription : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActorMovies",
                c => new
                    {
                        ActorMovieID = c.Int(nullable: false, identity: true),
                        MovieID = c.Int(nullable: false),
                        ActorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ActorMovieID)
                .ForeignKey("dbo.Actors", t => t.ActorID, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .Index(t => t.MovieID)
                .Index(t => t.ActorID);
            
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ActorId);
            
            AddColumn("dbo.Movies", "Description", c => c.String());
            AddColumn("dbo.Movies", "ViewerRating", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Movies", "ControlledViewerRating", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ActorMovies", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.ActorMovies", "ActorID", "dbo.Actors");
            DropIndex("dbo.ActorMovies", new[] { "ActorID" });
            DropIndex("dbo.ActorMovies", new[] { "MovieID" });
            DropColumn("dbo.Movies", "ControlledViewerRating");
            DropColumn("dbo.Movies", "ViewerRating");
            DropColumn("dbo.Movies", "Description");
            DropTable("dbo.Actors");
            DropTable("dbo.ActorMovies");
        }
    }
}
