namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PositionValidators : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Positions", "Position", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Positions", "Company", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Positions", "Years", c => c.String(nullable: false));
            AlterColumn("dbo.Positions", "Duties", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Positions", "Duties", c => c.String());
            AlterColumn("dbo.Positions", "Years", c => c.String());
            AlterColumn("dbo.Positions", "Company", c => c.String());
            AlterColumn("dbo.Positions", "Position", c => c.String());
        }
    }
}
