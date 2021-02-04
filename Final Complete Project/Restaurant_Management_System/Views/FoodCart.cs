using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management_System.Controllers;

namespace Restaurant_Management_System.Views
{
    public partial class FoodCart : Form
    {
        public FoodCart()
        {
            InitializeComponent();
            tbBurgerPrice.Text = FoodcartController.GetFoodPrice("Burger");
            tbPizzaPrice.Text = FoodcartController.GetFoodPrice("Pizza");
            tbSandwichPrice.Text = FoodcartController.GetFoodPrice("Sandwich");
            tbCokePrice.Text = FoodcartController.GetFoodPrice("Coke");
            tbCoffeePrice.Text = FoodcartController.GetFoodPrice("Coffee");
            tbTotalPrice.Text = "0";
            //BurgerQuantity.Value = 5;
        }


        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            FoodcartController.DeleteOrder();
            gridOrderDetails.DataSource = null;
            tbTotalPrice.Text = "0";

            BurgerQuantity.Value = 0;
            PizzaQuantity.Value = 0;
            SandwichQuantity.Value = 0;
            CokeQuantity.Value = 0;
            CoffeeQuantity.Value = 0;
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            int totalPrice = 0;
            if (BurgerQuantity.Value > 0) {
                FoodcartController.ConfirmOrder("Burger", tbBurgerPrice.Text, BurgerQuantity.Value.ToString(), (int.Parse(tbBurgerPrice.Text) * BurgerQuantity.Value).ToString());
                totalPrice += (int)(int.Parse(tbBurgerPrice.Text) * BurgerQuantity.Value);
            }

            if (PizzaQuantity.Value > 0) { 
                FoodcartController.ConfirmOrder("Pizza", tbPizzaPrice.Text, PizzaQuantity.Value.ToString(), (int.Parse(tbPizzaPrice.Text) * PizzaQuantity.Value).ToString());
                totalPrice += (int)(int.Parse(tbPizzaPrice.Text) * PizzaQuantity.Value);
            }
            
            if (SandwichQuantity.Value > 0) 
            {
                FoodcartController.ConfirmOrder("Sandwich", tbSandwichPrice.Text, SandwichQuantity.Value.ToString(), (int.Parse(tbSandwichPrice.Text) * SandwichQuantity.Value).ToString());
                totalPrice += (int)(int.Parse(tbSandwichPrice.Text) * SandwichQuantity.Value);
            }
            
            if (CokeQuantity.Value > 0)
            { 
                FoodcartController.ConfirmOrder("Coke", tbCokePrice.Text, CokeQuantity.Value.ToString(), (int.Parse(tbCokePrice.Text) * CokeQuantity.Value).ToString());
                totalPrice += (int)(int.Parse(tbCokePrice.Text) * CokeQuantity.Value);
            }
            
            if (CoffeeQuantity.Value > 0) 
            {
                FoodcartController.ConfirmOrder("Coffee", tbCoffeePrice.Text, CoffeeQuantity.Value.ToString(), (int.Parse(tbCoffeePrice.Text) * CoffeeQuantity.Value).ToString());
                totalPrice += (int)(int.Parse(tbCoffeePrice.Text) * CoffeeQuantity.Value);
            }
            
            gridOrderDetails.DataSource = FoodcartController.OrderInfo();
            tbTotalPrice.Text = totalPrice.ToString();
        }

        private void tbBurgerPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbPizzaPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BurgerQuantity_ValueChanged(object sender, EventArgs e)
        {
            //BurgerQuantity.Value = 5;
        }

        private void gridOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
