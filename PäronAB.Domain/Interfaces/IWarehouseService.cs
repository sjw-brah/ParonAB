using PäronAB.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
