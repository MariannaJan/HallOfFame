namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CertificatesWithR : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cetificates", newName: "Certificates");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Certificates", newName: "Cetificates");
        }
    }
}
