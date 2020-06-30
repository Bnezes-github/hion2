namespace Hion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreGeners : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES('Lesson')");
            Sql("INSERT INTO Genres (Name) VALUES('Event')");
            Sql("INSERT INTO Genres (Name) VALUES('Show')");
            Sql("INSERT INTO Genres (Name) VALUES('Other')");


        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (4, 5, 6, 7)");
        }
    }
}
