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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            new AddAdmin().Show();

        }

        private void btnUpdate_click(object sender, EventArgs e)
        {
            new UpdateDashboard().Show();
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            new AddManager().Show();
        }

        private void btnUpdateManager_Click(object sender, EventArgs e)
        {
            new ManagerDashboard().Show();
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            new InventoryDashboard().Show();
        }

        private void AddStaaf_Click(object sender, EventArgs e)
        {
            new CRUDStaffDashBoard().Show();
        }
    }
}
