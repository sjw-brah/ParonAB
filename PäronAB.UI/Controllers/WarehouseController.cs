using PäronAB.DataAccessLayer.Repositories;
using PäronAB.Domain.Interfaces;
using PäronAB.Domain.Models;
using PäronAB.Domain.Services;
using PäronAB.UI.ViewModels;
using System.Web.Mvc;

namespace PäronAB.UI.Controllers
{
    public class WarehouseController : Controller
    {
        IWarehouseService _warehouseService;
        //public WarehouseController(IWarehouseService warehouseService)
        //{
        //    _warehouseService = warehouseService;
        //}
        public WarehouseController()
        {
            _warehouseService = new WarehouseService(new WarehouseRepository(), new TransactionRepository());
        }
        public ActionResult Index()
        {
            var viewModel = new WarehouseListViewModel();
            viewModel.WarehouseList = _warehouseService.GetListOfWarehouses();
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Index(int id, string name)
        {
            var warehouse = new Warehouse { ID = id, Name = name };
            _warehouseService.SaveWarehouse(warehouse);

            return RedirectToAction("Index");
        }
    }
}