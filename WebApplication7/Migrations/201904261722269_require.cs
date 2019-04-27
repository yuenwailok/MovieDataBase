namespace WebApplication7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class require : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Movies", "Rating", c => c.String(nullable: false, maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Rating", c => c.String(maxLength: 5));
            AlterColumn("dbo.Movies", "Title", c => c.String(maxLength: 60));
        }
    }
}
