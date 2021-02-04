
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
    public partial class UserRegistrationForm : Form
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public UserRegistrationForm()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            var user = new
            {
                Id = 0,
                Name = tBName.Text,
                Username = tBUsername.Text,
                Password = tBPassword.Text
            };
            var result = UserController.AddUser(user);
            if (result!=null)
            {
                
                new UserHomepage().Show();
            }
            else
            {
                MessageBox.Show("Sorry! Could not Add User");
            }
            


        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
