namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DominWithS : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cetificates", name: "DomainId", newName: "DomainsId");
            RenameIndex(table: "dbo.Cetificates", name: "IX_DomainId", newName: "IX_DomainsId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Cetificates", name: "IX_DomainsId", newName: "IX_DomainId");
            RenameColumn(table: "dbo.Cetificates", name: "DomainsId", newName: "DomainId");
        }
    }
}
