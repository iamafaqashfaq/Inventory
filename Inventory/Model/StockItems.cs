﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    class StockItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public DateTime TransactionDate { get; set; }
        public int CategoryId { get; set; }
        public int UnitId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        [ForeignKey("UnitId")]

        public Unit Unit { get; set; }
    }
}
