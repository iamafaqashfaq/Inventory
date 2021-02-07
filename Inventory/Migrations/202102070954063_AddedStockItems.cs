namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStockItems : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockItems", "UnitId", "dbo.Units");
            DropForeignKey("dbo.StockItems", "CategoryId", "dbo.Categories");
            DropIndex("dbo.StockItems", new[] { "UnitId" });
            DropIndex("dbo.StockItems", new[] { "CategoryId" });
            DropTable("dbo.StockItems");
        }
    }
}
