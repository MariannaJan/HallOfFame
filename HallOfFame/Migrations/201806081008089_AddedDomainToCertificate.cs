namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDomainToCertificate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cetificates", "DomainId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cetificates", "DomainId");
            AddForeignKey("dbo.Cetificates", "DomainId", "dbo.Domains", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cetificates", "DomainId", "dbo.Domains");
            DropIndex("dbo.Cetificates", new[] { "DomainId" });
            DropColumn("dbo.Cetificates", "DomainId");
        }
    }
}
