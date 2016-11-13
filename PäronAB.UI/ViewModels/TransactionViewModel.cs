using PäronAB.Domain.Models;
using System.Collections.Generic;

namespace PäronAB.UI.ViewModels
{
    public class TransactionViewModel
    {
        public string Date { get; set; }
        public string ProductId { get; set; }
        public int WarehouseId { get; set; }
        public string Warehouse { get; set; }
        public int Quantity { get; set; }
        public List<Warehouse> Warehouses { get; set; }
        public List<Product> Products { get; set; }
    }
}
