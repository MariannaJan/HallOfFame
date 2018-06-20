namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class positionNameChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Positions", "PositionName", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Positions", "Position");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Positions", "Position", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Positions", "PositionName");
        }
    }
}
