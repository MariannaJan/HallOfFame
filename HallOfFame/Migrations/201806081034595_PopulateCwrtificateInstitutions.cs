namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCwrtificateInstitutions : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CertificateInstitutions (Name, Link, IssuesCertificate) VALUES ('Udemy', 'https://www.udemy.com/', 'True')");
            Sql("INSERT INTO CertificateInstitutions (Name, Link, IssuesCertificate) VALUES ('SoloLearn', 'https://www.sololearn.com/', 'False')");
            Sql("INSERT INTO CertificateInstitutions (Name, Link, IssuesCertificate) VALUES ('EdX', 'https://www.edx.org/', 'False')");
        }
        
        public override void Down()
        {
        }
    }
}
