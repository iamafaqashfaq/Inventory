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

        }
        public DbSet<Model.ApplicationUser> Users { get; set; }
        public DbSet<Model.Category> Category { get; set; }
        public DbSet<Model.Unit> Units { get; set; }
        public DbSet<Model.StockItems> StockItems { get; set; }
    }
}
