using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Restaurant_Management_System.Models
{
    public class Admins
    { 
        SqlConnection conn;
        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddAdmin(Admin admin)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Admins VALUES ('{0}', '{1}', '{2}')", admin.Name, admin.Username, admin.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if(r > 0)           
                return true;                     
             return false;           
        } 
        public Admin AuthenticateAdmin(string username, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Admins WHERE Username='{0}' and Password = '{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = null;
            while (reader.Read())
            {
                admin = new Admin();
                admin.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.Username = reader.GetString(reader.GetOrdinal("Username"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return admin;
        }

        public ArrayList GetAllAdmins()
        {
            ArrayList admins = new ArrayList();
            
            conn.Open();

            string query = "SELECT * FROM Admins";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                Admin admin = new Admin();
                admin = new Admin();
                admin.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.Username = reader.GetString(reader.GetOrdinal("Username"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
                admins.Add(admin);
                
            }
            conn.Close();
            return admins;
        }
        public Admin GetAdmin(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Admins WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = null;
            while (reader.Read())
            {
                admin = new Admin();
                admin.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.Username = reader.GetString(reader.GetOrdinal("Username"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return admin;
        }
        public bool UpdateAdmin(Admin admin)
        { 
            conn.Open();
            string query = String.Format("UPDATE Admins SET Name= '{0}' WHERE Username='{1}'", admin.Name, admin.Username);
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
        public bool DeleteAdmin(string username)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Admins WHERE Username= '{0}'", username);
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
