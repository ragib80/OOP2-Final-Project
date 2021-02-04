using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management_System.Models;

namespace Restaurant_Management_System.Controllers
{
    public class StaffController
    {
        static Database db = new Database();
        public static Staff AuthenticateStaff(string username, string password)
        {
            return db.Staffs.AuthenticateUser(username, password);
        }
        public static bool AddStaff(dynamic u)
        {
            Staff staff = new Staff();
            
            staff.Name = u.Name;
            staff.Username = u.Username;
            staff.Password = u.Password;
           //*staff.Salary = u.Salary;
            return db.Staffs.AddStaff(staff);
        }
        public static Staff GetStaff(string username)
        {
            return db.Staffs.GetStaff(username);
        }
        public static bool UpdateStaff(dynamic u)
        {
            Staff staff = new Staff();
            staff.Name = u.Name;
            staff.Username = u.Username;
            return db.Staffs.UpdateStaff(staff);
        }
        public static bool DeleteStaff(string username)
        {
            return db.Staffs.DeleteStaff(username);
        }
        public static ArrayList GetAllStaffs()
        {
            return db.Staffs.GetAllStaffs();
        }
    }
}
