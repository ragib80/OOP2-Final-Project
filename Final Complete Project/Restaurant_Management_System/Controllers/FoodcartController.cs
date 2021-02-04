using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management_System.Models;

namespace Restaurant_Management_System.Controllers
{
    class FoodcartController
    {
        static Database db = new Database();

        public static ArrayList GetFoodInfo()
        {
            return db.FoodMenus.GetFoodInfo();
        }
        public static FoodMenu GetFoodMenu(string foodItem)
        {
            return db.CrudFoodManus.GetFoodMenu(foodItem);
        }
        public static string GetFoodPrice(string foodItem)
        {
            return db.FoodMenus.GetFoodPrice(foodItem);
        }
        public static void ConfirmOrder(string foodItem, string foodPrice, string quantity, string totalPrice)
        {
            db.FoodMenus.ConfirmOrder(foodItem, foodPrice, quantity, totalPrice);
        }
        public static void DeleteOrder() {
            db.FoodMenus.DeleteOrder();
        }
        public static ArrayList OrderInfo()
        {
            return db.FoodMenus.OrderInfo();
        }
    }
}


