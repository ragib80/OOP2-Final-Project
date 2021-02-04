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
    public partial class CRUDStaffDashBoard : Form
    {
        public CRUDStaffDashBoard()
        {
            InitializeComponent();
            gridUsers.DataSource = StaffController.GetAllStaffs();
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            var staff = new
            {
                
                Name = tBManDsBName.Text,
                Username=tBManDsBUsername.Text,
                Password=tBManDsBPassword.Text,
                
            };
          var r=  StaffController.AddStaff(staff);
            if (r)
            {
                MessageBox.Show("user added");
              

            }
            else
            {
                MessageBox.Show("user not added");
            }
        }

        private void btnSearch(object sender, EventArgs e)
        {
           dynamic staff= StaffController.GetStaff(tBSearch.Text);
            if (staff != null)
            {
                tBSeachName.Text = staff.Name;
                tBSearchUsername.Text = staff.Username;
            }
            else
            {
                tBSeachName.Text = "";
                tBSearchUsername.Text = "";
                MessageBox.Show("cannot find staff");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchUpdate(object sender, EventArgs e)
        {
            var staff = new
            {
                Name = tBSeachName.Text,
             Username = tBSearchUsername.Text

            };
            var r = StaffController.UpdateStaff(staff);
            if (r)
            {
                MessageBox.Show("update success");

            }
            else
            {
                MessageBox.Show("could not update");
            }
        }

        private void BtnSearchDelete(object sender, EventArgs e)
        {
            var r = StaffController.DeleteStaff(tBSearchUsername.Text);
            if (r)
            {
                tBSeachName.Text = "";
                tBSearchUsername.Text = "";
                MessageBox.Show("staff deleted");

            }
            else
            {
                tBSeachName.Text = "";
                tBSearchUsername.Text = "";
                MessageBox.Show("cannot Delete");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
