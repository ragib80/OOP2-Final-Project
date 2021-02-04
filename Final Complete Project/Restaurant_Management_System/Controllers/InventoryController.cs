using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management_System.Models;

namespace Restaurant_Management_System.Controllers
{
    class InventoryController
    {
        static Database db = new Database();
        public static bool AddInventory(dynamic a)
        {
            Inventory inventory = new Inventory();
            inventory.Name = a.Name;
            inventory.Quantity = a.Quantity;
            //inventory.Password = a.Password;
            return db.Inventories.AddInventory(inventory);
        }

        public static Inventory GetInventory(string name)
        {
            return db.Inventories.GetInventory(name);
        }
        public static bool UpdateInventory(dynamic a)
        {
            Inventory inventory = new Inventory();
            inventory.Name = a.Name;
            inventory.Quantity = a.Quantity;
            return db.Inventories.UpdateInventory(inventory);
        }
        public static bool DeleteInventory(string name)
        {
            return db.Inventories.DeleteInventory(name);
        }
        public static ArrayList GetAllInventories()
        {
            return db.Inventories.GetAllInventories();
        }
    }
}
