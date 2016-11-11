using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PäronAB.UI.ViewModels
{
    public class TransactionViewModel
    {
        public DateTime Date { get; set; }
        public string ProductId { get; set; }
        public int WarehouseId { get; set; }
        public string Warehouse { get; set; }
        public int Quantity { get; set; }
    }
}
