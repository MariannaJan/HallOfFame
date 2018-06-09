namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PpulateDomais : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Domains (Name) VALUES ('HTML')");
            Sql("INSERT INTO Domains (Name) VALUES ('CSS')");
            Sql("INSERT INTO Domains (Name) VALUES ('JavaScript')");
            Sql("INSERT INTO Domains (Name) VALUES ('Bootstrap')");
            Sql("INSERT INTO Domains (Name) VALUES ('C#')");
            Sql("INSERT INTO Domains (Name) VALUES ('Python')");
            Sql("INSERT INTO Domains (Name) VALUES ('UX')");
        }
        
        public override void Down()
        {
        }
    }
}
