namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePositions : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Positions (Position, Company, Years, Duties) VALUES ('International Customer Service', 'MKF-Ergis Sp. z o.o.', '2016-2018', 'Day to day cooperation with customers and agents in regard of orders, deliveries and invoicing.')");
            Sql("INSERT INTO Positions (Position, Company, Years, Duties) VALUES ('Director of Secondary Market Department', 'Consus Brokerage House', '2011-2016', 'Managing the department and trading CO2 emission allowances, property rights, gas and electricity market')");
            Sql("INSERT INTO Positions (Position, Company, Years, Duties) VALUES ('Trader', 'Consus SA', '2007-2011', 'CO2 emission allowances trading')");
        }
        
        public override void Down()
        {
        }
    }
}
