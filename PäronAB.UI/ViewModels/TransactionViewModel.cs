using PäronAB.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
