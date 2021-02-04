using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Restaurant_Management_System.Models;

namespace Restaurant_Management_System.Controllers
{
    public class UserController
    {
        static Database db = new Database();
        
        public static User AuthenticateUser(string username, string password)
        {
            return db.Users.AutheticateUser(username, password);
        }
        public static bool AddUser(dynamic u)
        {
            User user = new User();
            user.Name = u.Name;
            user.Password = u.Password;
            user.Username = u.Username;

            return db.Users.AddUser(user);
        }

        public static User GetUser(string username)
        {
            return db.Users.GetUser(username);
        }
        public static bool UpdateUser(dynamic user)
        {
            User u = new User();
            u.Username = user.Username;
            u.Name = user.Name;
            return db.Users.UpdateUser(u);
        }

        internal static void Adduser(object user)
        {
            throw new NotImplementedException();
        }

        public static bool DeleteUser(string username)
        {
            return db.Users.DeleteUser(username);
        }
        public static ArrayList GetAllUsers()
        {
            return db.Users.GetAllUsers();
        }

    }
}
