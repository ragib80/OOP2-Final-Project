using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Restaurant_Management_System.Models
{
    public class CrudFoodManus
    {
        SqlConnection conn;
        public CrudFoodManus(SqlConnection conn)
        {
            this.conn = conn;
        }
        public FoodMenu GetFoodMenu(string foodItem)
        {
            conn.Open();
            string quary = string.Format("SELECT * FROM FoodMenu WHERE FoodItem='{0}'", foodItem);
            SqlCommand cmd = new SqlCommand(quary, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            FoodMenu foodMenu = null;
            while (reader.Read())
            {
                

                FoodMenu foodmenu = new FoodMenu();
                
                foodmenu.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                foodmenu.FoodItem = reader.GetString(reader.GetOrdinal("FoodItem"));
                foodmenu.FoodPrice = reader.GetString(reader.GetOrdinal("FoodPrice"));
            }
            conn.Close();
            return foodMenu;
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
        public bool UpdateFoodMenu(FoodMenu foodMenu)
        {
            conn.Open();
            string query = string.Format("UPDATE FoodMenu SET FoodItem='{0}', FoodPrice= '{1}' WHERE FoodItem='{2}'", foodMenu.FoodItem, foodMenu.FoodPrice,foodMenu.FoodPrice);
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
