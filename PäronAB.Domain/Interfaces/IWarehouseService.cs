using PäronAB.Domain.Models;
using System.Collections.Generic;

namespace PäronAB.Domain.Interfaces
{
    public interface IWarehouseService
    {
        int SaveWarehouse(Warehouse w);
        Warehouse GetWarehouseById(int id);
        List<Warehouse> GetListOfWarehouses();
        List<Transaction> GetStockValues();
    }
}
