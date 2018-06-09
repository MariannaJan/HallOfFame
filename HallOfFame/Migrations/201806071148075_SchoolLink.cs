namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SchoolLink : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schools", "Link", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schools", "Link");
        }
    }
}
