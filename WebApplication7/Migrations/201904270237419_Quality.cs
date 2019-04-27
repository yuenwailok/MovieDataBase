namespace WebApplication7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Quality : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Quality", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Quality");
        }
    }
}
