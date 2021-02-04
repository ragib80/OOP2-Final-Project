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
    public partial class InventoryDashboard : Form
    {
        public InventoryDashboard()
        {
            InitializeComponent();
            gridInventories.DataSource = InventoryController.GetAllInventories();
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            var inventory = new
            {
                Name = tbInventoryName.Text,
                Quantity = tbInventoryQuantity.Text,               
            };
            var r = InventoryController.AddInventory(inventory);
            if (r)
            {
                MessageBox.Show("Inventory Added!");
                gridInventories.DataSource = InventoryController.GetAllInventories();
            }
            else
            {
                MessageBox.Show("Inventory not Added!");
            }
        }

        private void btnInventorySearch_Click(object sender, EventArgs e)
        {
            dynamic inventory = InventoryController.GetInventory(tbInventorySearch.Text);
            if (inventory != null)
            {
                tbNameModify.Text = inventory.Name;
                tbQuantityModify.Text = inventory.Quantity;
            }
            else
            {
                tbNameModify.Text = "";
                tbQuantityModify.Text = "";
                MessageBox.Show("Inventory not found!");
            }
        }

        private void btnUpdateModify_Click(object sender, EventArgs e)
        {
            var inventory = new
            {
                Name = tbNameModify.Text,
                Quantity = tbQuantityModify.Text,
            };
            var r = InventoryController.UpdateInventory(inventory);
            if (r)
            {
                tbNameModify.Text = "";
                tbQuantityModify.Text = "";
                MessageBox.Show("Successfully Updated!");
                gridInventories.DataSource = InventoryController.GetAllInventories();
            }
            else
            {
                MessageBox.Show("Failed to update");
            }
        }

        private void btnDeleteModify_Click(object sender, EventArgs e)
        {
            var r = InventoryController.DeleteInventory(tbNameModify.Text);
            if (r)
            {
                tbNameModify.Text = "";
                tbQuantityModify.Text = "";
                MessageBox.Show("Inventory Deleted!");
                gridInventories.DataSource = InventoryController.GetAllInventories();
            }
            else
            {
                tbNameModify.Text = "";
                tbQuantityModify.Text = "";
                MessageBox.Show("Can not Delete!");
            }
        }
    }
}
