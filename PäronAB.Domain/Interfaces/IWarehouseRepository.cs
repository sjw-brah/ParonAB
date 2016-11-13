using PäronAB.Domain.Models;
using System.Collections.Generic;

namespace PäronAB.Domain.Interfaces
{
    public interface IWarehouseRepository
    {
        int SaveWarehouse(Warehouse w);
        Warehouse GetWarehouseById(int Id);
        List<Warehouse> GetListOfWarehouses();
    }
}
