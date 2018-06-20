namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomValidator : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Positions", "Years", c => c.String(nullable: false, maxLength: 9));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Positions", "Years", c => c.String(nullable: false));
        }
    }
}
