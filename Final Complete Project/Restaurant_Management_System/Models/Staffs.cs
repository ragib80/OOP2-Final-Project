using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Restaurant_Management_System.Models
{
    public class Staffs
    {
        SqlConnection conn;
        public Staffs(SqlConnection conn)
        {
            this.conn = conn;
        }

        public bool AddStaff(Staff staff)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Staffs VALUES('{0}','{1}','{2}')",  staff.Name, staff.Username, staff.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
         public Staff AuthenticateUser(string username,string password)
        {
            conn.Open();
            string quary = string.Format("SELECT * FROM Staffs WHERE Username='{0}'and Password='{1}'",username,password);
            SqlCommand cmd = new SqlCommand(quary, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Staff staff = null;
            while (reader.Read())
            {
                staff = new Staff();
                staff.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                staff.Name = reader.GetString(reader.GetOrdinal("Name"));
                staff.Username = reader.GetString(reader.GetOrdinal("Username"));
                staff.Password = reader.GetString(reader.GetOrdinal("Password"));
                //*staff.Salary = reader.GetInt32(reader.GetOrdinal("Salary"));
            }
            conn.Close();
            return staff;
             
        }
        public ArrayList GetAllStaffs()
        {
            ArrayList staffs = new ArrayList();
            conn.Open();
            string quary = string.Format("SELECT * FROM Staffs ");
            SqlCommand cmd = new SqlCommand(quary, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Staff staff = new Staff();
                staff = new Staff();
                staff.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                staff.Name = reader.GetString(reader.GetOrdinal("Name"));
                staff.Username = reader.GetString(reader.GetOrdinal("Username"));
                staff.Password = reader.GetString(reader.GetOrdinal("Password"));
                //*staff.Salary = reader.GetInt32(reader.GetOrdinal("Salary"));
                staffs.Add(staff);
            }
            conn.Close();
            return staffs;

        }
        public Staff GetStaff(string username)
        {
            conn.Open();
            string quary = string.Format("SELECT * FROM Staffs WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(quary, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Staff staff = null;
            while (reader.Read())
            {
                staff = new Staff();
                staff.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                staff.Name = reader.GetString(reader.GetOrdinal("Name"));
                staff.Username = reader.GetString(reader.GetOrdinal("Username"));
                staff.Password = reader.GetString(reader.GetOrdinal("Password"));
                //*staff.Salary = reader.GetInt32(reader.GetOrdinal("Salary"));
            }
            conn.Close();
            return staff;
        }

        public bool UpdateStaff(Staff staff)
        {
            conn.Open();
            string query = string.Format("UPDATE Staffs SET Name='{0}' WHERE Username='{1}'", staff.Name,  staff.Username);
            SqlCommand cmd = new SqlCommand(query,conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
            {
                return true;

            }
            return false;
        }

        public bool DeleteStaff(string username)
        {
            conn.Open();
            string query = string.Format("DELETE FROM Staffs WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
            {
                return true;

            }
            return false;

        }

     
    }
}
