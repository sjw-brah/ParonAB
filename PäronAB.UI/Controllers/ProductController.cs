using PäronAB.DataAccessLayer.Repositories;
using PäronAB.Domain.Interfaces;
using PäronAB.Domain.Models;
using PäronAB.Domain.Services;
using PäronAB.UI.ViewModels;
using System.Web.Mvc;

namespace PäronAB.UI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;

        public ProductController()
        {
            _productService = new ProductService(new ProductRepository());
        }
        public ActionResult Index()
        {
            var viewModel = new ProductListViewModel();

            viewModel.ProductList = _productService.GetListOfProducts();
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Index(string sku = null, string name = null, decimal price = 0)
        {
            if (sku != null && name != null && price != 0)
            {
                var product = new Product { Name = name, SKU = sku, UnitPrice = price };
                _productService.SaveProduct(product);
            }

            return RedirectToAction("Index");

        }

    }
}