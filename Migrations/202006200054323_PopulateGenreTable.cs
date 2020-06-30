namespace Hion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES('Meeting')");
            Sql("INSERT INTO Genres (Name) VALUES('Class')");
            Sql("INSERT INTO Genres (Name) VALUES('Session')");
            Sql("INSERT INTO Genres (Name) VALUES('Other')");

        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
