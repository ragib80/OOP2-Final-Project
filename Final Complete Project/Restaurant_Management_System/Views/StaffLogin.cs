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
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void StaffLogin_Click(object sender, EventArgs e)
        {
            string username = tbStaffLgUsername.Text;
            string password = tbStaffLgPassword.Text;
            var r =StaffController.AuthenticateStaff(username, password);
            if (r != null)
            {
                MessageBox.Show("Login Successful!");

                new StaffDashBoardcs().Show();
                //new AdminHome().Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void Staff_HomeClick(object sender, EventArgs e)
        {
            this.Close();
            new HomePage().Show();
        }
    }
}
