using PäronAB.Domain.Models;
using System.Collections.Generic;

namespace PäronAB.Domain.Interfaces
{
    public interface IProductService
    {
        int SaveProduct(Product p);
        Product GetProductBySKU(string id);
        List<Product> GetListOfProducts();
    }
}
