using PäronAB.Domain.Models;
using System.Collections.Generic;

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
