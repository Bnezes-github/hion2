namespace Hion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateHionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Venue = c.String(),
                        Genre_Id = c.Int(),
                        Host_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.Genre_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Host_Id)
                .Index(t => t.Genre_Id)
                .Index(t => t.Host_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hions", "Host_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Hions", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Hions", new[] { "Host_Id" });
            DropIndex("dbo.Hions", new[] { "Genre_Id" });
            DropTable("dbo.Hions");
            DropTable("dbo.Genres");
        }
    }
}
