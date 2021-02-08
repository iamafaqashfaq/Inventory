namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTransactionID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StockOuts", "TransactionID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.StockOuts", "TransactionID");
        }
    }
}
