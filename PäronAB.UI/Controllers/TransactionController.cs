using PäronAB.DataAccessLayer.Repositories;
using PäronAB.Domain.Interfaces;
using PäronAB.Domain.Models;
using PäronAB.Domain.Services;
using PäronAB.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PäronAB.UI.Controllers
{
    public class TransactionController : Controller
    {
        ITransactionService _transactionService;
        IWarehouseRepository _warehouseRepository;
        IProductRepository _productRepository;

        public TransactionController()
        {
            _transactionService = new TransactionService(new TransactionRepository());
            _warehouseRepository = new WarehouseRepository();
            _productRepository = new ProductRepository();
        }
        public ActionResult Index()
        {
            List<TransactionViewModel> viewModel = new List<TransactionViewModel>();
            var query = from t in _transactionService.GetTransactions()
                        join w in _warehouseRepository.GetListOfWarehouses() on t.WarehouseId equals w.ID
                        select new { Date = t.Date.ToShortDateString(), ProductId = t.ProductId, Quantity = t.Quantity, Warehouse = w.Name, WarehouseId = w.ID };
            var warehouses = _warehouseRepository.GetListOfWarehouses();
            var products = _productRepository.GetListOfProducts();

            foreach (var item in query)
            {
                viewModel.Add(new TransactionViewModel
                {
                    Date = item.Date,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Warehouse = item.Warehouse,
                    WarehouseId = item.WarehouseId,
                    Warehouses = warehouses,
                    Products = products
                });
            }
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            string sku = form["product"];
            int warehouseId = int.Parse(form["warehouse"].ToString());
            string date = form["date"].ToString();
            int qty = int.Parse(form["qty"].ToString());

            var product = _productRepository.GetBySKU(sku);

            var transaction = new Transaction
            {
                Date = DateTime.Parse(date),
                ID = Guid.NewGuid(),
                ProductId = sku,
                Quantity = qty,
                Sum = qty * product.UnitPrice,
                WarehouseId = warehouseId
            };

            _transactionService.SaveTransaction(transaction);

            return RedirectToAction("Index");
        }
    }
}