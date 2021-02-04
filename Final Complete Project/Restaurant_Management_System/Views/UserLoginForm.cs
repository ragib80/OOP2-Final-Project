
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
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

       
      

        private void butLogin_Click_1(object sender, EventArgs e)
        {
            string username = tboxUsername.Text;
            string password = tboxPassword.Text;
            var r = UserController.AuthenticateUser(username, password);
            if (r != null)
            {
                
                new UserHomepage().Show();

            }
            else
            {
                MessageBox.Show("Sorry!! Not Valid ");
            }
        }

        private void butRegister_Click(object sender, EventArgs e)
        {
            new UserRegistrationForm().Show();

        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
