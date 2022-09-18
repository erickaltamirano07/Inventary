using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Warehouse
    {
        public List<WarehouseEntity> WarehousesList()
        {
            using (var db= new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }
        public void CreateWareHouse(WarehouseEntity warehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(warehouse);
                db.SaveChanges();
            }
        }
        public void UpdateWareHouse(WarehouseEntity warehouse)
        {
            using(var db= new InventaryContext())
            {
                db.Warehouses.Update(warehouse);
                db.SaveChanges();
            }
        }
        public void RemoveWareouse(WarehouseEntity warehouse)
        {
            using(var db = new InventaryContext())
            {
                db.Warehouses.Remove(warehouse);
                db.SaveChanges();
            }
        }
    }
}
