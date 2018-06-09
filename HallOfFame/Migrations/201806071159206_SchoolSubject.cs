namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SchoolSubject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schools", "Subject", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schools", "Subject");
        }
    }
}
