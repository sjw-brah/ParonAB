using PäronAB.DataAccessLayer.Repositories;
using PäronAB.Domain.Interfaces;
using PäronAB.Domain.Services;
using PäronAB.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PäronAB.UI.Controllers
{
    public class StockController : Controller
    {
        ITransactionService _transactionService;
        IWarehouseService _warehouseService;

        public StockController()
        {
            _transactionService = new TransactionService(new TransactionRepository());
            _warehouseService = new WarehouseService(new WarehouseRepository(), new TransactionRepository());
        }
        public ActionResult Index()
        {
            var stockLevels = new List<StockLevelViewModel>();
            var query = from t in _transactionService.GetTransactions()
                        join w in _warehouseService.GetListOfWarehouses() on t.WarehouseId equals w.ID
                        group t by new
                        {
                            Product = t.ProductId,
                            Warehouse = w.Name

                        } into view
                        select new StockLevelViewModel
                        {
                            Product = view.Key.Product,
                            Warehouse = view.Key.Warehouse,
                            StockValue = view.Sum(x => x.Sum)
                        };

            foreach (var post in query)
            {
                stockLevels.Add(post);
            }
            return View(stockLevels);
        }
    }
}