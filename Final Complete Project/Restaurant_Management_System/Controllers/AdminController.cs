using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Restaurant_Management_System.Models;
using System.Collections;

namespace Restaurant_Management_System.Controllers
{
    public class AdminController
    {
        static Database db = new Database();
        public static Admin AuthenticateAdmin(string username, string password)
        {
            return db.Admins.AuthenticateAdmin(username, password);

        }

        public static bool AddAdmin(dynamic a)
        {
            Admin admin = new Admin();
            admin.Name = a.Name;
            admin.Username = a.Username;
            admin.Password = a.Password;            
            return db.Admins.AddAdmin(admin);
        }

        public static Admin GetAdmin(string username)
        {
            return db.Admins.GetAdmin(username);
        } 
        public static bool UpdateAdmin(dynamic a)
        {
            Admin admin = new Admin();
            admin.Name = a.Name;
            admin.Username = a.Username;
            return db.Admins.UpdateAdmin(admin);
        }
        public static bool DeleteAdmin(string username)
        {
            return db.Admins.DeleteAdmin(username);
        }
        public static ArrayList GetAllAdmins()
        {
            return db.Admins.GetAllAdmins();
        }
    }


}
