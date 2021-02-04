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
    public partial class CrudFoodMenu : Form
    {
        public CrudFoodMenu()
        {
            InitializeComponent();
            gridFoodItems.DataSource = FoodcartController.GetFoodInfo();
        }

        private void FoodItmSch_Click(object sender, EventArgs e)
        {
            dynamic foodMenu = FoodcartController.GetFoodMenu(tBFoodItemSeach.Text);
            if (foodMenu != null)
            {
                tBMFoodItemName.Text = foodMenu.FoodItem;
                tBMFoodItemPrice.Text =foodMenu.FoodPrice;
            }
            else
            {
                tBMFoodItemName.Text = "";
                tBMFoodItemPrice.Text = "";
                MessageBox.Show("cannot find food");
            }

        }

        private void BtnScFoodItem_Update(object sender, EventArgs e)
        {

        }
    }
}
