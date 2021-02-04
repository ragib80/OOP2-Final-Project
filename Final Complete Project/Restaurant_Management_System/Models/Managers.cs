using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Models
{
    public class Managers
    {
        SqlConnection conn;
        public Managers(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddManager(Manager manager)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Managers VALUES ('{0}', '{1}', '{2}','{3}')", manager.Name, manager.Username, manager.Password, manager.Salary);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            return false;
        }
        public Manager AuthenticateManager(string username, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Managers WHERE Username='{0}' and Password = '{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
           Manager manager = null;
            while (reader.Read())
            {
                manager = new Manager();
                manager.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                manager.Name = reader.GetString(reader.GetOrdinal("Name"));
                manager.Username = reader.GetString(reader.GetOrdinal("Username"));
                manager.Password = reader.GetString(reader.GetOrdinal("Password"));              
                manager.Salary = reader.GetString(reader.GetOrdinal("Salary"));                                       
            }
            conn.Close();
            return manager;
        }
        public ArrayList GetAllManagers()
        {
            ArrayList managers = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Managers";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Manager manager = new Manager();
                manager = new Manager();
                manager.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                manager.Name = reader.GetString(reader.GetOrdinal("Name"));
                manager.Username = reader.GetString(reader.GetOrdinal("Username"));
                manager.Password = reader.GetString(reader.GetOrdinal("Password"));
                manager.Salary = reader.GetString(reader.GetOrdinal("Salary"));
                Console.WriteLine(reader.GetString(reader.GetOrdinal("Salary")) + "xxx");
                managers.Add(manager);
            }

            conn.Close();
            return managers;
        }
        public Manager GetManager(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Managers WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Manager manager = null;
            while (reader.Read())
            {
                manager = new Manager();
                manager.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                manager.Name = reader.GetString(reader.GetOrdinal("Name"));
                manager.Username = reader.GetString(reader.GetOrdinal("Username"));
                manager.Password = reader.GetString(reader.GetOrdinal("Password"));
                manager.Salary = reader.GetString(reader.GetOrdinal("Salary"));
            }
            conn.Close();
            return manager;
        }
        public bool UpdateManager(Manager manager)
        {
            conn.Open();
            string query = String.Format("UPDATE Managers SET Name= '{0}', Salary= '{1}' WHERE Username='{2}'", manager.Name, manager.Salary, manager.Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
        public bool DeleteManager(string username)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Managers WHERE Username= '{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

    }
}
