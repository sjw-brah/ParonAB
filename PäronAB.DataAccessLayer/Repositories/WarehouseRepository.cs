using PäronAB.Domain.Interfaces;
using PäronAB.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace PäronAB.DataAccessLayer.Repositories
{
    public class WarehouseRepository : IWarehouseRepository
    {
        static List<Warehouse> _warehouseList = new List<Warehouse>
        {
            new Warehouse {ID=1,Name="Cupertino" },
            new Warehouse {ID=2,Name="Norrköping" },
            new Warehouse {ID=3,Name="Frankfurt" }
        };
        public List<Warehouse> GetListOfWarehouses()
        {
            return _warehouseList;
        }

        public Warehouse GetWarehouseById(int Id)
        {
            return _warehouseList.FirstOrDefault(w => w.ID == Id);

        }

        public int SaveWarehouse(Warehouse w)
        {

            var warehouse = _warehouseList.FirstOrDefault(x => x.ID == w.ID);
            if (warehouse == null)
            {
                //w.ID = _warehouseList.Max(i => i.ID) + 1;
                _warehouseList.Add(w);
            }
            else
            {
                w.ID = warehouse.ID;
                _warehouseList.Remove(warehouse);
                _warehouseList.Add(w);
            }

            return w.ID;

        }
    }
}
