using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PäronAB.UI.ViewModels
{
    public class StockLevelViewModel
    {
        public string Product { get; set; }
        public string Warehouse { get; set; }
        public decimal StockValue { get; set; }
    }
}
