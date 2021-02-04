
namespace Restaurant_Management_System.Views
{
    partial class StaffLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbStaffLgUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStaffLgPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStaffLogin = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // tbStaffLgUsername
            // 
            this.tbStaffLgUsername.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStaffLgUsername.Location = new System.Drawing.Point(203, 120);
            this.tbStaffLgUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbStaffLgUsername.Name = "tbStaffLgUsername";
            this.tbStaffLgUsername.Size = new System.Drawing.Size(172, 30);
            this.tbStaffLgUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // tbStaffLgPassword
            // 
            this.tbStaffLgPassword.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStaffLgPassword.Location = new System.Drawing.Point(203, 195);
            this.tbStaffLgPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbStaffLgPassword.Name = "tbStaffLgPassword";
            this.tbStaffLgPassword.Size = new System.Drawing.Size(172, 30);
            this.tbStaffLgPassword.TabIndex = 5;
            this.tbStaffLgPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Staff Login";
            // 
            // btnStaffLogin
            // 
            this.btnStaffLogin.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffLogin.Location = new System.Drawing.Point(250, 243);
            this.btnStaffLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnStaffLogin.Name = "btnStaffLogin";
            this.btnStaffLogin.Size = new System.Drawing.Size(84, 33);
            this.btnStaffLogin.TabIndex = 7;
            this.btnStaffLogin.Text = "Login";
            this.btnStaffLogin.UseVisualStyleBackColor = true;
            this.btnStaffLogin.Click += new System.EventHandler(this.StaffLogin_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Salmon;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(31, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 58);
            this.button5.TabIndex = 35;
            this.button5.Text = "Go Home Page";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Staff_HomeClick);
            // 
            // StaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnStaffLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStaffLgPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbStaffLgUsername);
            this.Controls.Add(this.label2);
            this.Name = "StaffLogin";
            this.Text = "StaffLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStaffLgUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStaffLgPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStaffLogin;
        private System.Windows.Forms.Button button5;
    }
}