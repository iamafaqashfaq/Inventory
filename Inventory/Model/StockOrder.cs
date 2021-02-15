using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    class StockOrder
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string contactnumber { get; set; }
        public double price { get; set; }
        public double discount { get; set; }
        public double payable { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
