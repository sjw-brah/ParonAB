using PäronAB.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PäronAB.Domain.Models;

namespace PäronAB.Domain.Services
{
    public class WarehouseService : IWarehouseService
    {
        IWarehouseRepository _warehouseRepo;
        ITransactionRepository _transactionRepo;
        public WarehouseService(IWarehouseRepository warehouseRepo, ITransactionRepository transactionRepo)
        {
            _warehouseRepo = warehouseRepo;
            _transactionRepo = transactionRepo;
        }
        public List<Warehouse> GetListOfWarehouses()
        {
            return _warehouseRepo.GetListOfWarehouses();
        }

        public List<Transaction> GetStockValues()
        {
            return _transactionRepo.GetTransactions();
        }

        public Warehouse GetWarehouseById(int id)
        {
            return _warehouseRepo.GetWarehouseById(id);
        }

        public int SaveWarehouse(Warehouse w)
        {
            int id = _warehouseRepo.SaveWarehouse(w);
            return id;
        }
    }
}
