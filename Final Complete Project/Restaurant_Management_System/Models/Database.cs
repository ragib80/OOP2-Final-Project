using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurant_Management_System.Models
{
    class Database
    {
        public Staffs Staffs { get; set; }
        public FoodMenus FoodMenus { get; }
        public Admins Admins { get; set; }
        public Managers Managers { get; set; }
        public Customers Customers { get; set; }
        public CrudFoodManus CrudFoodManus { get; set; }
        public Users Users { get; set; }

        public Inventories Inventories { get; set; }

        public Database()
        {
            string connString = @"Server=DESKTOP-90T47VU\SQLEXPRESS;User Id=sa;Password=123456;Database=Restaurent_Management_System";
            SqlConnection conn = new SqlConnection(connString);
            Staffs = new Staffs(conn);
            FoodMenus = new FoodMenus(conn);
            Admins = new Admins(conn);
            Managers = new Managers(conn);
            Inventories = new Inventories(conn);
            Customers = new Customers(conn);
            CrudFoodManus = new CrudFoodManus(conn);
            Users = new Users(conn);
        }
    }
}
