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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            //admin authentication
            var r = AdminController.AuthenticateAdmin(username, password);
            if(r != null)
            {
                MessageBox.Show("Login Successful!");
                new AdminHome().Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
            /*
            //manager authentication
            var q = ManagerController.AuthenticateManager(username, password);
            if (q != null)
            {
                MessageBox.Show("Login Successful!");
                new AdminHome().Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }*/
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
            new HomePage().Show();
        }
    }
}
