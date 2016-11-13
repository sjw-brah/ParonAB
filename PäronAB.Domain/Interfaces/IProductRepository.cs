using PäronAB.Domain.Models;
using System.Collections.Generic;

namespace PäronAB.Domain.Interfaces
{
    public interface IProductRepository
    {
        int Save(Product p);
        Product GetBySKU(string id);
        List<Product> GetListOfProducts();
    }
}
