﻿using System;
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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DbIndex_click(object sender, EventArgs e)
        {
            this.Hide();
            new CRUDStaffDashBoard().Show();

        }

        private void MenuIndex_Click(object sender, EventArgs e)
        {
            new CrudFoodMenu().Show();
        }

        private void InvenIndex_Click(object sender, EventArgs e)
        {
            new InventoryDashboard().Show();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            
        }
    }
}
