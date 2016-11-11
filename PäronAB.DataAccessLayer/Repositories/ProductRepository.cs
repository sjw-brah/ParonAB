using PäronAB.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PäronAB.Domain.Models;

namespace PäronAB.DataAccessLayer.Repositories
{
    public class ProductRepository : IProductRepository
    {
        static List<Product> _productList = new List<Product>
            {
                new Product {ID=1,Name="jTelefon",SKU="P001",UnitPrice=8900 },
                new Product {ID=2,Name="jPlatta",SKU="P002",UnitPrice=5700 },
                new Product {ID=3,Name="Päronklocka",SKU="P003",UnitPrice=11000 },
            };
        public Product GetBySKU(string id)
        {
            return _productList.FirstOrDefault(p => p.SKU == id);
        }

        public List<Product> GetListOfProducts()
        {
            return _productList;
        }

        public int Save(Product p)
        {
            var product = _productList.FirstOrDefault(x => x.SKU == p.SKU);

            if (product == null)
            {
                p.ID = _productList.Count;
                _productList.Add(p);
            }
            else
            {
                p.ID = product.ID;
                _productList.Remove(product);
                _productList.Add(p);
            }
            return p.ID;
        }
    }
}
