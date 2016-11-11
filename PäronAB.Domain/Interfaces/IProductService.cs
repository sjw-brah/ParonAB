using PäronAB.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PäronAB.Domain.Interfaces
{
    public interface IProductService
    {
        int SaveProduct(Product p);
        Product GetProductBySKU(string id);
        List<Product> GetListOfProducts();
    }
}
