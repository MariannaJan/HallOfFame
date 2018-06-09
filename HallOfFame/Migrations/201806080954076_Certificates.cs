namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Certificates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cetificates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        link = c.String(),
                        CertificateInstitutionsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CertificateInstitutions", t => t.CertificateInstitutionsId, cascadeDelete: true)
                .Index(t => t.CertificateInstitutionsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cetificates", "CertificateInstitutionsId", "dbo.CertificateInstitutions");
            DropIndex("dbo.Cetificates", new[] { "CertificateInstitutionsId" });
            DropTable("dbo.Cetificates");
        }
    }
}
