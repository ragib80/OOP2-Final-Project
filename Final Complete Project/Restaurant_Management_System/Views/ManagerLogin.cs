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
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void ManagerLogin_Click(object sender, EventArgs e)
        {
            string username = tBManagerUsername.Text;
            string password = tBManagerPassword.Text;
            var v = ManagerController.AuthenticateManager(username, password);
            if (v != null)
            {
                MessageBox.Show("user valid");
                this.Hide();
                
                new Manager().Show();

            }
            else
            {
                MessageBox.Show("user not valid");
            }
        }

        private void ManagerHome_clck(object sender, EventArgs e)
        {
            this.Close();
            new HomePage().Show();
        }
    }
}
