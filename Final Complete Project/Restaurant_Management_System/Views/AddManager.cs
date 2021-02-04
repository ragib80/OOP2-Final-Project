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
    public partial class AddManager : Form
    {
        public AddManager()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            var manager = new
            {
                Name = tbManagerName.Text,
                Username = tbManagerUsername.Text,
                Password = tbManagerPassword.Text,
                Salary = tbManagerSalary.Text

            };
            var r = ManagerController.AddManager(manager);
            if (r)
            {
                MessageBox.Show("User Added!");
            }
            else
            {
                MessageBox.Show("User not Added!");
            }
        }
    }
}
