using PäronAB.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PäronAB.Domain.Interfaces
{
    public interface IWarehouseRepository
    {
        int SaveWarehouse(Warehouse w);
        Warehouse GetWarehouseById(int Id);
        List<Warehouse> GetListOfWarehouses();
    }
}
