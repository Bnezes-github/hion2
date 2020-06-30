namespace Hion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeysPropertiesToHion : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Hions", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Hions", new[] { "Genre_Id" });
            RenameColumn(table: "dbo.Hions", name: "Host_Id", newName: "HostId");
            RenameIndex(table: "dbo.Hions", name: "IX_Host_Id", newName: "IX_HostId");
            AddColumn("dbo.Hions", "GenrerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Hions", "Genre_Id", c => c.Int());
            CreateIndex("dbo.Hions", "Genre_Id");
            AddForeignKey("dbo.Hions", "Genre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hions", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Hions", new[] { "Genre_Id" });
            AlterColumn("dbo.Hions", "Genre_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Hions", "GenrerId");
            RenameIndex(table: "dbo.Hions", name: "IX_HostId", newName: "IX_Host_Id");
            RenameColumn(table: "dbo.Hions", name: "HostId", newName: "Host_Id");
            CreateIndex("dbo.Hions", "Genre_Id");
            AddForeignKey("dbo.Hions", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
