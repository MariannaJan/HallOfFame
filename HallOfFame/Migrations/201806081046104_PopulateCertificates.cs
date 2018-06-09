namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCertificates : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('Website from Scratch in 1 hour using Bootstrap 4','https://www.udemy.com/certificate/UC-IZJ8S5KS/', 1, 4)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('ES6 / EcmaScript Fast Crash Course', 'https://www.udemy.com/certificate/UC-0GU3SQBB/', 1, 3)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('Javascript for beginners - Quick JavaScript Fundamentals', 'https://www.udemy.com/certificate/UC-65681ZMG/', 1, 3)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('jQuery Basics - Tutorial for Beginners', 'https://www.udemy.com/certificate/UC-4U79NFBH/', 1, 3)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('30 Days of Python | Unlock your Python Potential', 'https://www.udemy.com/certificate/UC-K67SG54M/', 1, 6)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('The HTML And CSS Bootcamp', 'https://www.udemy.com/certificate/UC-OI4R52O1/', 1, 1)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('Learn Python 3.6 for Total Beginners', 'https://www.udemy.com/certificate/UC-17ZZWF8J/', 1, 6)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('The Complete Python 3 Course: Go from Beginner to Advanced!', 'https://www.udemy.com/certificate/UC-GPNIYQGP/', 1, 6)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('Innovation #1 Design Thinking : Create New Business Ideas', 'https://www.udemy.com/certificate/UC-EVZXX1A5/', 1, 7)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('Fastrack WEB DEVLOPMENT: Learn HTML5, CSS3, JavaScript', 'https://www.udemy.com/certificate/UC-QS2BSZ1Y/', 1, 2)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('HTML Fundamentals', '', 2, 1)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('CSS Fundamentals', '', 2, 2)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('JavaScript Tutorial', '', 2, 3)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('jQuery Tutorial', '', 2, 3)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('C# Tutorial', '', 2, 5)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('Understanding User Needs', '', 3, 7)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('Introduction to User Experience', '', 3, 7)");
            Sql("INSERT INTO Certificates (name, link, CertificateInstitutionsId, DomainsId) VALUES ('Principles of Designing for Humans', '', 3, 7)");
        }
        
        public override void Down()
        {
        }
    }
}
