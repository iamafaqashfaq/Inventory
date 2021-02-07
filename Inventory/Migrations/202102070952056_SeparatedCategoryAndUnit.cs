namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeparatedCategoryAndUnit : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CUSettings", newName: "Categories");
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Categories", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Type", c => c.String());
            DropTable("dbo.Units");
            RenameTable(name: "dbo.Categories", newName: "CUSettings");
        }
    }
}
