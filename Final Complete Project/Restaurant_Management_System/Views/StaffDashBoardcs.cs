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
    public partial class StaffDashBoardcs : Form
    {
        public StaffDashBoardcs()
        {
            InitializeComponent();
            gridStaffUsers.DataSource = CustomerControllers.GetAllCustomer();
        }

        private void StaffDashBoardcs_Load(object sender, EventArgs e)
        {

        }

        private void AddCustomerSt_Click(object sender, EventArgs e)
        {
            var customer = new
            {

                Name = tBStaffDsBName.Text,
                Username = tBStaffDsBUsername.Text,
                Password = tBStaffDsBPassword.Text,

            };
            var r = CustomerControllers.AddCustomer(customer);
            if (r)
            {
                MessageBox.Show("user added");


            }
            else
            {
                MessageBox.Show("user not added");
            }
        }

        private void CustomerUpdate_click(object sender, EventArgs e)
        {
            var customer= new
            {
                Name = tBCustomerSeachName.Text,
                Username = tBCustomerSearchUsername.Text

            };
            var r = CustomerControllers.UpdateCustomer(customer);
            if (r)
            {
                MessageBox.Show("update success");

            }
            else
            {
                MessageBox.Show("could not update");
            }
        }

        private void CustomerDelete_Click(object sender, EventArgs e)
        {
            var customer = new
            {
                Name = tBCustomerSeachName.Text,
                Username = tBCustomerSearchUsername.Text,

            };
            var r = CustomerControllers.DeleteCustomer(tBCustomerSearchUsername.Text);
            if (r)
            {
                MessageBox.Show("delete successfully");

            }
            else
            {
                MessageBox.Show("could not delete");
            }
        }

        private void CustomerSch_Click(object sender, EventArgs e)
        {
            dynamic customer = CustomerControllers.GetCustomer(tBStaffDbSearch.Text);
            if (customer != null)
            {
                tBCustomerSeachName.Text = customer.Name;
                tBCustomerSearchUsername.Text = customer.Username;
            }
            else
            {
                tBCustomerSeachName.Text = "";
                tBCustomerSearchUsername.Text = "";
                MessageBox.Show("cannot find staff");
            }
        }

        private void GoHomeStaff_click(object sender, EventArgs e)
        {
            this.Close();
            new HomePage().Show();

        }
    }
}
