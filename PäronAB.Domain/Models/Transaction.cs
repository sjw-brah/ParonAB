using System;

namespace PäronAB.Domain.Models
{
    public class Transaction
    {
        public Guid ID { get; set; }
        public string ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int Quantity { get; set; }
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
    }
}
