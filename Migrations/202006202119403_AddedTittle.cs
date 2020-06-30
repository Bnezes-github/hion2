namespace Hion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTittle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hions", "Title", c => c.String(nullable: false, maxLength: 1500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hions", "Title");
        }
    }
}
