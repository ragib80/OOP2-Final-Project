namespace Restaurant_Management_System.Views
{
    partial class AddManager
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
            this.tbManagerName = new System.Windows.Forms.TextBox();
            this.tbManagerUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbManagerPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbManagerSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbManagerName
            // 
            this.tbManagerName.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbManagerName.Location = new System.Drawing.Point(136, 100);
            this.tbManagerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbManagerName.Name = "tbManagerName";
            this.tbManagerName.Size = new System.Drawing.Size(211, 30);
            this.tbManagerName.TabIndex = 2;
            this.tbManagerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbManagerUsername
            // 
            this.tbManagerUsername.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbManagerUsername.Location = new System.Drawing.Point(136, 143);
            this.tbManagerUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbManagerUsername.Name = "tbManagerUsername";
            this.tbManagerUsername.Size = new System.Drawing.Size(211, 30);
            this.tbManagerUsername.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbManagerPassword
            // 
            this.tbManagerPassword.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbManagerPassword.Location = new System.Drawing.Point(136, 187);
            this.tbManagerPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbManagerPassword.Name = "tbManagerPassword";
            this.tbManagerPassword.Size = new System.Drawing.Size(211, 30);
            this.tbManagerPassword.TabIndex = 6;
            this.tbManagerPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // tbManagerSalary
            // 
            this.tbManagerSalary.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbManagerSalary.Location = new System.Drawing.Point(136, 233);
            this.tbManagerSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbManagerSalary.Name = "tbManagerSalary";
            this.tbManagerSalary.Size = new System.Drawing.Size(211, 30);
            this.tbManagerSalary.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Salary";
            // 
            // btnAddManager
            // 
            this.btnAddManager.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddManager.Location = new System.Drawing.Point(254, 283);
            this.btnAddManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddManager.Name = "btnAddManager";
            this.btnAddManager.Size = new System.Drawing.Size(92, 34);
            this.btnAddManager.TabIndex = 9;
            this.btnAddManager.Text = "Add";
            this.btnAddManager.UseVisualStyleBackColor = true;
            this.btnAddManager.Click += new System.EventHandler(this.btnAddManager_Click);
            // 
            // AddManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnAddManager);
            this.Controls.Add(this.tbManagerSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbManagerPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbManagerUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbManagerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddManager";
            this.Text = "AddManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbManagerName;
        private System.Windows.Forms.TextBox tbManagerUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbManagerPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbManagerSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddManager;
    }
}