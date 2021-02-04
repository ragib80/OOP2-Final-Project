using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management_System.Models;
using System.Collections;

namespace Restaurant_Management_System.Controllers
{
    class ManagerController
    {
        static Database db = new Database();
        public static Manager AuthenticateManager(string username, string password)
        {
            return db.Managers.AuthenticateManager(username, password);
        }
        public static bool AddManager(dynamic a)
        {
            Manager manager = new Manager();
            manager.Name = a.Name;
            manager.Username = a.Username;
            manager.Password = a.Password;
            manager.Salary = a.Salary;
            return db.Managers.AddManager(manager);
        }
        public static Manager GetManager(string username)
        {
            return db.Managers.GetManager(username);
        }
        public static bool UpdateManager(dynamic a)
        {
            Manager manager = new Manager();
            manager.Name = a.Name;
            manager.Username = a.Username;
            return db.Managers.UpdateManager(manager);
        }
        public static bool DeleteManager(string username)
        {
            return db.Managers.DeleteManager(username);
        }
        public static ArrayList GetAllManagers()
        {
            return db.Managers.GetAllManagers();
        }

    }
}
