using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model.ViewModel
{
    class InvoiceVM
    {
        public string name { get; set; }
        public string stockitem { get; set; }
        public int qty { get; set; }
        public double price { get; set; }
        public double total { get; set; }
        public double discount { get; set; }
        public double grandtotal { get; set; }
    }
}
