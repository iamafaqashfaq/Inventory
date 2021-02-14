namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDiscount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StockOuts", "Discount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StockOuts", "Discount");
        }
    }
}
