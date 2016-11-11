using PäronAB.DataAccessLayer.Repositories;
using PäronAB.Domain.Interfaces;
using PäronAB.Domain.Models;
using PäronAB.Domain.Services;
using PäronAB.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PäronAB.UI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        //public ProductController(ProductService productService)
        //{
        //    _productService = productService;
        //}
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
        public ActionResult Index(string sku, string name, decimal price)
        {
            var product = new Product { Name = name, SKU = sku, UnitPrice = price };
            _productService.SaveProduct(product);

            return RedirectToAction("Index");

        }

    }
}