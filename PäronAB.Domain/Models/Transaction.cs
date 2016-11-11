using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PäronAB.Domain.Models
{
    public class Transaction
    {
        public Guid ID { get; set; }
        public string ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int Quantity { get; set; }
        public decimal CostPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
