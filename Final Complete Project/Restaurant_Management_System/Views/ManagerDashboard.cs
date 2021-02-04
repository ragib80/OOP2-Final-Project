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
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard()
        {
            InitializeComponent();
            gridManagers.DataSource = ManagerController.GetAllManagers();
        }

        private void btnManagerSearch_Click(object sender, EventArgs e)
        {
            dynamic manager = ManagerController.GetManager(tbSearch.Text);
            if (manager != null)
            {
                tbManagerName.Text = manager.Name;
                tbManagerUsername.Text = manager.Username;
            }
            else
            {
                tbManagerName.Text = "";
                tbManagerUsername.Text = "";
                MessageBox.Show("Manager not found!");
            }
        }

        private void btnManagerUpdate_Click(object sender, EventArgs e)
        {
            var manager = new
            {
                Name = tbManagerName.Text,
                Username = tbManagerUsername.Text,
            };
            var r = ManagerController.UpdateManager(manager);
            if (r)
            {
                tbManagerName.Text = "";
                tbManagerUsername.Text = "";
                MessageBox.Show("Successfully Updated!");
                gridManagers.DataSource = ManagerController.GetAllManagers();
            }
            else
            {
                MessageBox.Show("Failed to update");
            }
        }

        //private void btnManagerDelete(object sender, EventArgs e)
        //{
        //
       // }

        private void btnManagerDelete_Click(object sender, EventArgs e)
        {
            var r = ManagerController.DeleteManager(tbManagerUsername.Text);
            if (r)
            {
                tbManagerName.Text = "";
                tbManagerUsername.Text = "";
                MessageBox.Show("Manager Deleted!");
                gridManagers.DataSource = ManagerController.GetAllManagers();
            }
            else
            {
                tbManagerName.Text = "";
                tbManagerUsername.Text = "";
                MessageBox.Show("Can not Delete!");
            }
        }
    }
}

