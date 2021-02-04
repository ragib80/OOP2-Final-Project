using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System.Views
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void ManagerLogin_click(object sender, EventArgs e)
        {
            this.Hide();
            new ManagerLogin().Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void StaffLog_Click(object sender, EventArgs e)
        {
            new StaffLogin().Show();
            this.Hide();
        }

        private void UserLogin_Clk(object sender, EventArgs e)
        {
            new Controllers.UserLoginForm().Show();


        }
    }
}
