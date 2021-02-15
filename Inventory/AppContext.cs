using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class AppContext : DbContext
    {
        public AppContext() : base("name=conn")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppContext, Inventory.Migrations.Configuration>());
        }
        public DbSet<Model.ApplicationUser> Users { get; set; }
        public DbSet<Model.Category> Category { get; set; }
        public DbSet<Model.Unit> Units { get; set; }
        public DbSet<Model.StockItems> StockItems { get; set; }
        public DbSet<Model.StockOut> StockOut { get; set; }
        public DbSet<Model.StockOrder> StockOrders { get; set; }
    }
}
