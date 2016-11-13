using PäronAB.Domain.Interfaces;
using PäronAB.Domain.Models;
using System.Collections.Generic;

namespace PäronAB.Domain.Services
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepo;
        public ProductService(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public List<Product> GetListOfProducts()
        {
            return _productRepo.GetListOfProducts();
        }

        public Product GetProductBySKU(string id)
        {
            return _productRepo.GetBySKU(id);
        }

        public int SaveProduct(Product p)
        {
            return _productRepo.Save(p);
        }
    }
}
