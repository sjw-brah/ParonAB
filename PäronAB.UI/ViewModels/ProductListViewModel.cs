using PäronAB.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PäronAB.UI.ViewModels
{
    public class ProductListViewModel
    {
        public ProductListViewModel()
        {
            ProductList = new List<Product>();
        }
        public List<Product> ProductList { get; set; }
    }
}
