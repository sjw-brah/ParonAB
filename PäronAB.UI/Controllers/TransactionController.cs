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
    public class TransactionController : Controller
    {
        ITransactionService _transactionService;
        IWarehouseRepository _warehouseRepository;
        //public TransactionController(ITransactionService transactionService)
        //{
        //    _transactionService = transactionService;
        //}
        public TransactionController()
        {
            _transactionService = new TransactionService(new TransactionRepository());
            _warehouseRepository = new WarehouseRepository();
        }
        public ActionResult Index()
        {
            List<TransactionViewModel> viewModel = new List<TransactionViewModel>();
            var query = from t in _transactionService.GetTransactions()
                        join w in _warehouseRepository.GetListOfWarehouses() on t.WarehouseId equals w.ID
                        select new { Date = t.Date, ProductId = t.ProductId, Quantity = t.Quantity, Warehouse = w.Name, WarehouseId = w.ID };

            foreach (var item in query)
            {
                viewModel.Add(new TransactionViewModel { Date = item.Date, ProductId = item.ProductId, Quantity = item.Quantity, Warehouse = item.Warehouse, WarehouseId = item.WarehouseId });
            }
            return View(viewModel);
        }
    }
}