namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StockItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Qty = c.Int(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        UnitId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.UnitId);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StockOuts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ContactNumber = c.String(),
                        StockItemId = c.Int(nullable: false),
                        Qty = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                        TransactionID = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StockItems", t => t.StockItemId, cascadeDelete: true)
                .Index(t => t.StockItemId);
            
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockOuts", "StockItemId", "dbo.StockItems");
            DropForeignKey("dbo.StockItems", "UnitId", "dbo.Units");
            DropForeignKey("dbo.StockItems", "CategoryId", "dbo.Categories");
            DropIndex("dbo.StockOuts", new[] { "StockItemId" });
            DropIndex("dbo.StockItems", new[] { "UnitId" });
            DropIndex("dbo.StockItems", new[] { "CategoryId" });
            DropTable("dbo.ApplicationUsers");
            DropTable("dbo.StockOuts");
            DropTable("dbo.Units");
            DropTable("dbo.StockItems");
            DropTable("dbo.Categories");
        }
    }
}
