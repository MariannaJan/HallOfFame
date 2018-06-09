namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSchools : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Schools (SchoolName, Years, Link, Subject) VALUES ('Polish-Japanese Academy of Information Technology', '2015-2019', 'https://gdansk.pjwstk.edu.pl/', 'Engineer degree - IT - external studies')");
            Sql("INSERT INTO Schools (SchoolName, Years, Link, Subject) VALUES ('WSB University in Toruñ', '2014-2015', 'https://www.wsb.pl/english/program-offerings/torun', 'Postgraduate studies - Econimic - legal translation - English')");
            Sql("INSERT INTO Schools (SchoolName, Years, Link, Subject) VALUES ('Poznañ University of Economics and Business', '2000-2005', 'http://ue.poznan.pl/en/', 'Master degree - Economics / finance and banking')");
        }
        
        public override void Down()
        {
        }
    }
}
