namespace Restaurant_Management_System.Views
{
    partial class InventoryDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddInventory = new System.Windows.Forms.Button();
            this.tbInventoryQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInventoryName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInventorySearch = new System.Windows.Forms.TextBox();
            this.btnInventorySearch = new System.Windows.Forms.Button();
            this.btnUpdateModify = new System.Windows.Forms.Button();
            this.tbQuantityModify = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNameModify = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteModify = new System.Windows.Forms.Button();
            this.gridInventories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventories)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modify Inventory";
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInventory.Location = new System.Drawing.Point(322, 294);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(135, 41);
            this.btnAddInventory.TabIndex = 26;
            this.btnAddInventory.Text = "Add";
            this.btnAddInventory.UseVisualStyleBackColor = true;
            this.btnAddInventory.Click += new System.EventHandler(this.btnAddInventory_Click);
            // 
            // tbInventoryQuantity
            // 
            this.tbInventoryQuantity.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventoryQuantity.Location = new System.Drawing.Point(229, 235);
            this.tbInventoryQuantity.Name = "tbInventoryQuantity";
            this.tbInventoryQuantity.Size = new System.Drawing.Size(228, 35);
            this.tbInventoryQuantity.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Quantity";
            // 
            // tbInventoryName
            // 
            this.tbInventoryName.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventoryName.Location = new System.Drawing.Point(229, 181);
            this.tbInventoryName.Name = "tbInventoryName";
            this.tbInventoryName.Size = new System.Drawing.Size(228, 35);
            this.tbInventoryName.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Name";
            // 
            // tbInventorySearch
            // 
            this.tbInventorySearch.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventorySearch.Location = new System.Drawing.Point(649, 175);
            this.tbInventorySearch.Name = "tbInventorySearch";
            this.tbInventorySearch.Size = new System.Drawing.Size(228, 35);
            this.tbInventorySearch.TabIndex = 27;
            // 
            // btnInventorySearch
            // 
            this.btnInventorySearch.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventorySearch.Location = new System.Drawing.Point(906, 175);
            this.btnInventorySearch.Name = "btnInventorySearch";
            this.btnInventorySearch.Size = new System.Drawing.Size(112, 35);
            this.btnInventorySearch.TabIndex = 28;
            this.btnInventorySearch.Text = "Search";
            this.btnInventorySearch.UseVisualStyleBackColor = true;
            this.btnInventorySearch.Click += new System.EventHandler(this.btnInventorySearch_Click);
            // 
            // btnUpdateModify
            // 
            this.btnUpdateModify.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateModify.Location = new System.Drawing.Point(883, 348);
            this.btnUpdateModify.Name = "btnUpdateModify";
            this.btnUpdateModify.Size = new System.Drawing.Size(135, 41);
            this.btnUpdateModify.TabIndex = 33;
            this.btnUpdateModify.Text = "Update";
            this.btnUpdateModify.UseVisualStyleBackColor = true;
            this.btnUpdateModify.Click += new System.EventHandler(this.btnUpdateModify_Click);
            // 
            // tbQuantityModify
            // 
            this.tbQuantityModify.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantityModify.Location = new System.Drawing.Point(790, 289);
            this.tbQuantityModify.Name = "tbQuantityModify";
            this.tbQuantityModify.Size = new System.Drawing.Size(228, 35);
            this.tbQuantityModify.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(650, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "Quantity";
            // 
            // tbNameModify
            // 
            this.tbNameModify.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameModify.Location = new System.Drawing.Point(790, 235);
            this.tbNameModify.Name = "tbNameModify";
            this.tbNameModify.Size = new System.Drawing.Size(228, 35);
            this.tbNameModify.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(650, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Name";
            // 
            // btnDeleteModify
            // 
            this.btnDeleteModify.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteModify.Location = new System.Drawing.Point(729, 348);
            this.btnDeleteModify.Name = "btnDeleteModify";
            this.btnDeleteModify.Size = new System.Drawing.Size(135, 41);
            this.btnDeleteModify.TabIndex = 34;
            this.btnDeleteModify.Text = "Delete";
            this.btnDeleteModify.UseVisualStyleBackColor = true;
            this.btnDeleteModify.Click += new System.EventHandler(this.btnDeleteModify_Click);
            // 
            // gridInventories
            // 
            this.gridInventories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInventories.Location = new System.Drawing.Point(558, 413);
            this.gridInventories.Name = "gridInventories";
            this.gridInventories.RowHeadersWidth = 51;
            this.gridInventories.RowTemplate.Height = 24;
            this.gridInventories.Size = new System.Drawing.Size(549, 173);
            this.gridInventories.TabIndex = 35;
            // 
            // InventoryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 608);
            this.Controls.Add(this.gridInventories);
            this.Controls.Add(this.btnDeleteModify);
            this.Controls.Add(this.btnUpdateModify);
            this.Controls.Add(this.tbQuantityModify);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNameModify);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInventorySearch);
            this.Controls.Add(this.tbInventorySearch);
            this.Controls.Add(this.btnAddInventory);
            this.Controls.Add(this.tbInventoryQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbInventoryName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InventoryDashboard";
            this.Text = "InventoryDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.gridInventories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddInventory;
        private System.Windows.Forms.TextBox tbInventoryQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInventoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInventorySearch;
        private System.Windows.Forms.Button btnInventorySearch;
        private System.Windows.Forms.Button btnUpdateModify;
        private System.Windows.Forms.TextBox tbQuantityModify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNameModify;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteModify;
        private System.Windows.Forms.DataGridView gridInventories;
    }
}