namespace Hion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForHionsAndGenres : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Hions", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Hions", "Host_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Hions", new[] { "Genre_Id" });
            DropIndex("dbo.Hions", new[] { "Host_Id" });
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Hions", "Venue", c => c.String(nullable: false, maxLength: 1500));
            AlterColumn("dbo.Hions", "Genre_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Hions", "Host_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Hions", "Genre_Id");
            CreateIndex("dbo.Hions", "Host_Id");
            AddForeignKey("dbo.Hions", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Hions", "Host_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hions", "Host_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Hions", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Hions", new[] { "Host_Id" });
            DropIndex("dbo.Hions", new[] { "Genre_Id" });
            AlterColumn("dbo.Hions", "Host_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Hions", "Genre_Id", c => c.Int());
            AlterColumn("dbo.Hions", "Venue", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            CreateIndex("dbo.Hions", "Host_Id");
            CreateIndex("dbo.Hions", "Genre_Id");
            AddForeignKey("dbo.Hions", "Host_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Hions", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
