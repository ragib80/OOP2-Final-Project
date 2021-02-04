using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Models
{
   public class FoodMenus
    {
        SqlConnection conn;
        public FoodMenus(SqlConnection conn)
        {
            this.conn = conn;
        }

        public ArrayList GetFoodInfo()
        {
            ArrayList foodmenus = new ArrayList();

            conn.Open();

            string query = "SELECT * FROM FoodMenu";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                FoodMenu foodmenu = new FoodMenu();
                foodmenu = new FoodMenu();
                foodmenu.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                foodmenu.FoodItem = reader.GetString(reader.GetOrdinal("FoodItem"));
                foodmenu.FoodPrice = reader.GetString(reader.GetOrdinal("FoodPrice"));

                foodmenus.Add(foodmenu);

            }
            conn.Close();
            return foodmenus;
        }

        public string GetFoodPrice(string foodItem)
        {
            string foodPrice = null;
            conn.Open();
            // string foodPrice;

            string query = String.Format("SELECT * FROM FoodMenu WHERE FoodItem = '{0}'", foodItem);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                foodPrice = reader.GetString(reader.GetOrdinal("FoodPrice"));

            }
            conn.Close();
            return foodPrice;
        }

        public void ConfirmOrder(string foodItem, string foodPrice, string quantity, string totalPrice)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Billings VALUES ('{0}', '{1}', '{2}', '{3}')", foodItem, foodPrice, quantity, totalPrice);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteOrder()
        {
            conn.Open();
            string query = "TRUNCATE TABLE Billings";
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public ArrayList OrderInfo()
        {
            ArrayList billingList = new ArrayList();

            conn.Open();

            string query = "SELECT * FROM Billings";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Billings billings = new Billings();
                //billings = new FoodMenu();
                billings.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                billings.FoodItem = reader.GetString(reader.GetOrdinal("FoodItem"));
                billings.FoodPrice = reader.GetString(reader.GetOrdinal("FoodPrice"));
                billings.Quantity = reader.GetString(reader.GetOrdinal("Quantity"));
                billings.TotalPrice = reader.GetString(reader.GetOrdinal("TotalPrice"));

                billingList.Add(billings);

            }
            conn.Close();
            return billingList;
        }
    }
}
