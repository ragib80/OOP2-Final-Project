
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Restaurant_Management_System.Views;

namespace Restaurant_Management_System.Controllers
{
    public partial class UserHomepage : Form
    {
        public UserHomepage()
        {
            InitializeComponent();
           /* var ds = FooditemController.GetAllMenu();
            GVHome.DataSource = ds;*/

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           /* string name = tBSearch.Text;
            dynamic user = FooditemController.GetAllMenu();
            if (user != null )
            {
                
                MessageBox.Show("Food avaiable");

            }
            else
            {
                

                MessageBox.Show("No Avaiable");
            }*/
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }

        private void UserMenu_Click(object sender, EventArgs e)
        {
            new FoodCart().Show();
        }
    }
}
