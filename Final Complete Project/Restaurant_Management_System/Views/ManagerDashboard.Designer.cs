namespace Restaurant_Management_System.Views
{
    partial class ManagerDashboard
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gridManagers = new System.Windows.Forms.DataGridView();
            this.btnManagerUpdate = new System.Windows.Forms.Button();
            this.tbManagerUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbManagerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManagerDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridManagers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(399, 57);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnManagerSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(119, 57);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(276, 27);
            this.tbSearch.TabIndex = 11;
            // 
            // gridManagers
            // 
            this.gridManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridManagers.Location = new System.Drawing.Point(21, 249);
            this.gridManagers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridManagers.Name = "gridManagers";
            this.gridManagers.RowHeadersWidth = 51;
            this.gridManagers.RowTemplate.Height = 24;
            this.gridManagers.Size = new System.Drawing.Size(644, 196);
            this.gridManagers.TabIndex = 22;
            // 
            // btnManagerUpdate
            // 
            this.btnManagerUpdate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerUpdate.Location = new System.Drawing.Point(372, 202);
            this.btnManagerUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManagerUpdate.Name = "btnManagerUpdate";
            this.btnManagerUpdate.Size = new System.Drawing.Size(75, 27);
            this.btnManagerUpdate.TabIndex = 20;
            this.btnManagerUpdate.Text = "Update";
            this.btnManagerUpdate.UseVisualStyleBackColor = true;
            this.btnManagerUpdate.Click += new System.EventHandler(this.btnManagerUpdate_Click);
            // 
            // tbManagerUsername
            // 
            this.tbManagerUsername.Enabled = false;
            this.tbManagerUsername.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbManagerUsername.Location = new System.Drawing.Point(252, 127);
            this.tbManagerUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbManagerUsername.Name = "tbManagerUsername";
            this.tbManagerUsername.Size = new System.Drawing.Size(196, 27);
            this.tbManagerUsername.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Username";
            // 
            // tbManagerName
            // 
            this.tbManagerName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbManagerName.Location = new System.Drawing.Point(252, 96);
            this.tbManagerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbManagerName.Name = "tbManagerName";
            this.tbManagerName.Size = new System.Drawing.Size(196, 27);
            this.tbManagerName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Manager Dashboard";
            // 
            // btnManagerDelete
            // 
            this.btnManagerDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerDelete.Location = new System.Drawing.Point(275, 202);
            this.btnManagerDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManagerDelete.Name = "btnManagerDelete";
            this.btnManagerDelete.Size = new System.Drawing.Size(81, 27);
            this.btnManagerDelete.TabIndex = 24;
            this.btnManagerDelete.Text = "Delete";
            this.btnManagerDelete.UseVisualStyleBackColor = true;
            this.btnManagerDelete.Click += new System.EventHandler(this.btnManagerDelete_Click);
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 471);
            this.Controls.Add(this.btnManagerDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridManagers);
            this.Controls.Add(this.btnManagerUpdate);
            this.Controls.Add(this.tbManagerUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbManagerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerDashboard";
            this.Text = "ManagerDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.gridManagers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView gridManagers;
        //private System.Windows.Forms.Button btnManagerDelete;
        private System.Windows.Forms.Button btnManagerUpdate;
        private System.Windows.Forms.TextBox tbManagerUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbManagerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManagerDelete;
        //private System.Windows.Forms.Button button1;
    }
}