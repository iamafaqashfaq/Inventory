namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStockOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        contactnumber = c.String(),
                        price = c.Double(nullable: false),
                        discount = c.Double(nullable: false),
                        payable = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.StockOuts", "StockOrderId", c => c.Int(nullable: false));
            CreateIndex("dbo.StockOuts", "StockOrderId");
            AddForeignKey("dbo.StockOuts", "StockOrderId", "dbo.StockOrders", "Id", cascadeDelete: true);
            DropColumn("dbo.StockOuts", "Discount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StockOuts", "Discount", c => c.Double(nullable: false));
            DropForeignKey("dbo.StockOuts", "StockOrderId", "dbo.StockOrders");
            DropIndex("dbo.StockOuts", new[] { "StockOrderId" });
            DropColumn("dbo.StockOuts", "StockOrderId");
            DropTable("dbo.StockOrders");
        }
    }
}
