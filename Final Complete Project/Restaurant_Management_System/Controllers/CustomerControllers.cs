using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management_System.Models;
using System.Collections;

namespace Restaurant_Management_System.Controllers
{
    class CustomerControllers
    {
        static Database db = new Database();
        public static Customer AuthenticateAdmin(string username, string password)
        {
            return db.Customers.AuthenticateCustomer(username, password);

        }

        public static bool AddCustomer(dynamic a)
        {
            Customer customer = new Customer();
            customer.Name = a.Name;
            customer.Username = a.Username;
            customer.Password = a.Password;
            return db.Customers.AddCustomer(customer);
        }

        public static Customer GetCustomer(string username)
        {
            return db.Customers.GetCustomer(username);
        }
        public static bool UpdateCustomer(dynamic a)
        {
            Customer customer = new Customer();
            customer.Name = a.Name;
            customer.Username = a.Username;
            return db.Customers.UpdateCustomer(customer);
        }
        public static bool DeleteCustomer(string username)
        {
            return db.Customers.DeleteCustomer(username);
        }
        public static ArrayList GetAllCustomer()
        {
            return db.Customers.GetAllCustomers();
        }

        internal static object DeleteCustomer(object customer)
        {
            throw new NotImplementedException();
        }
    }
}
