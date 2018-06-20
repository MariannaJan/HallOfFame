namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePositionsTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Positions SET PositionName = 'International Customer Service' WHERE Id=3");
            Sql("UPDATE dbo.Positions SET PositionName = 'Director of Secondary Market Department', Company='Consus Brokerage House', Years='2011-2016' WHERE Id=4");
            Sql("UPDATE dbo.Positions SET PositionName = 'Trader' WHERE Id=5");
        }
        
        public override void Down()
        {
        }
    }
}
