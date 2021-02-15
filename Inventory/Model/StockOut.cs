using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    class StockOut
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public int StockItemId { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionID { get; set; }
        public int StockOrderId { get; set; }
        [ForeignKey("StockItemId")]
        public StockItems StockItems { get; set; }
        [ForeignKey("StockOrderId")]

        public StockOrder StockOrder { get; set; }
    }
}