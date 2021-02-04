using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Models
{
    class Inventories
    {
        SqlConnection conn;
        public Inventories(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddInventory(Inventory inventory)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Inventories VALUES ('{0}', '{1}')", inventory.Name, inventory.Quantity);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            return false;
        }
        public ArrayList GetAllInventories()
        {
            ArrayList inventories = new ArrayList();

            conn.Open();

            string query = "SELECT * FROM Inventories";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Inventory inventory = new Inventory();
                inventory = new Inventory();
                inventory.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                inventory.Name = reader.GetString(reader.GetOrdinal("Name"));
                inventory.Quantity = reader.GetString(reader.GetOrdinal("Quantity"));
                //inventory.Password = reader.GetString(reader.GetOrdinal("Password"));
                inventories.Add(inventory);

            }
            conn.Close();
            return inventories;
        }
        public Inventory GetInventory(string name)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Inventories WHERE Name='{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Inventory inventory = null;
            while (reader.Read())
            {
                inventory = new Inventory();
                inventory.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                inventory.Name = reader.GetString(reader.GetOrdinal("Name"));
                inventory.Quantity = reader.GetString(reader.GetOrdinal("Quantity"));
                //inventory.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return inventory;
        }
        public bool UpdateInventory(Inventory inventory)
        {
            conn.Open();
            string query = String.Format("UPDATE Inventories SET Name= '{0}', Quantity= '{1}' WHERE Name='{2}'", inventory.Name, inventory.Quantity, inventory.Name);
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

        public bool DeleteInventory(string name)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Inventories WHERE Name= '{0}'", name);
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
